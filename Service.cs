using System;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using AssineBem.Core;
using Newtonsoft.Json;

namespace AssineBem
{
    public class Service
    {
        private readonly string UrlAssinatura = "https://www.assinebem.com.br/api";
        protected HttpClient Http;
        public HashAlgorithm Sha256;

        public Service(string secret, string token)
        {
            ServicePointManager.SecurityProtocol =
                SecurityProtocolType.Tls12 | SecurityProtocolType.Tls11 | SecurityProtocolType.Tls;
            Http = new HttpClient { BaseAddress = new Uri(UrlAssinatura) };
            Secret = secret;
            Token = token;
            Sha256 = SHA256.Create();
        }

        protected string Secret { get; set; }
        protected string Token { get; set; }

        private string EncodeToBase64(string texto)
        {
            var textoAsBytes = Encoding.ASCII.GetBytes(texto);
            var resultado = Convert.ToBase64String(textoAsBytes);
            return resultado;
        }

        public string DecodeFrom64(string dados)
        {
            var dadosAsBytes = Convert.FromBase64String(dados);
            var resultado = Encoding.ASCII.GetString(dadosAsBytes);
            return resultado;
        }

        public async Task<Retorno> GetIdentificador()
        {
            try
            {
                var urlUuid = $"{UrlAssinatura}/documento/get_identifier_to_upload";
                var input = $"{urlUuid}{Secret}";
                var hash = GetHash(Sha256, input);
                Http.DefaultRequestHeaders.Clear();
                Http.DefaultRequestHeaders.Add("SECURITY-HASH", EncodeToBase64($"{Token}:{hash}"));
                var getUuid = await Http.GetAsync(urlUuid).ConfigureAwait(false);
                var contentUuid = await getUuid.Content.ReadAsStringAsync().ConfigureAwait(false);
                var uiid = JsonConvert.DeserializeObject<Retorno>(contentUuid);
                return uiid;
            }
            catch (Exception e)
            {
                return new Retorno { Status = 100, Mensagem = e.Message };
            }
        }

        public async Task<DocumentoRetorno> UploadDocumento(Upload objetoPostado)
        {
            try
            {
                var item = JsonConvert.SerializeObject(objetoPostado);
                var stringContent = new StringContent(item);
                stringContent.Headers.ContentType = new MediaTypeHeaderValue("application/json");
                var urlPostArquivo = $"{UrlAssinatura}/documento";
                var input = $"{urlPostArquivo}{Secret}{item}";
                var hash = GetHash(Sha256, input);
                Http.DefaultRequestHeaders.Clear();
                Http.DefaultRequestHeaders.Add("SECURITY-HASH", EncodeToBase64($"{Token}:{hash}"));
                var response = await Http.PostAsync(urlPostArquivo, stringContent).ConfigureAwait(false);
                var json = await response.Content.ReadAsStringAsync().ConfigureAwait(false);
                var x = JsonConvert.DeserializeObject<DocumentoRetorno>(json);
                return x;
            }
            catch (Exception e)
            {
                return new DocumentoRetorno { Status = 100, Mensagem = e.Message };
            }

        }

        public async Task<DocumentoRetorno> ConsultaDocumento(string idExterno)
        {
            try
            {
                var urlPostArquivo = $"{UrlAssinatura}/documento/?id_externo={idExterno}";
                var hash = GetHash(Sha256, $"{UrlAssinatura}{urlPostArquivo}{Secret}");
                Http.DefaultRequestHeaders.Clear();
                Http.DefaultRequestHeaders.Add("SECURITY-HASH", $"{Token}:{hash}");
                var response = await Http.GetAsync(urlPostArquivo).ConfigureAwait(false);
                var json = await response.Content.ReadAsStringAsync().ConfigureAwait(false);
                var x = JsonConvert.DeserializeObject<DocumentoRetorno>(json);
                return x;
            }
            catch (Exception e)
            {
                return new DocumentoRetorno { Status = 100, Mensagem = e.Message };
            }
        }

        public async Task<byte[]> BaixaDocumento(string idExterno)
        {
            try
            {
                var urlPostArquivo = $"/documento/download_arquivo/?id_externo={idExterno}";
                var hash = GetHash(Sha256, $"{UrlAssinatura}{urlPostArquivo}{Secret}");
                Http.DefaultRequestHeaders.Clear();
                Http.DefaultRequestHeaders.Add("SECURITY-HASH", $"{Token}:{hash}");
                var response = await Http.GetByteArrayAsync(urlPostArquivo).ConfigureAwait(false);
                return response;
            }
            catch (Exception e)
            {
                return null;
            }
        }

        private static string GetHash(HashAlgorithm hashAlgorithm, string input)
        {
            var data = hashAlgorithm.ComputeHash(Encoding.UTF8.GetBytes(input));
            var sBuilder = new StringBuilder();
            foreach (var t in data) sBuilder.Append(t.ToString("x2"));
            return sBuilder.ToString();
        }
    }
}