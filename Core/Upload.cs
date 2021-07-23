using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace AssineBem.Core
{
    public class Upload
    {
        /// <summary>
        /// obrigatório. Identificador do documento, gerado por get_identifier_to_upload
        /// </summary>
        [JsonProperty("id_identifier")] public string IdIdentifier { get; set; }

        /// <summary>
        /// URL com documento PDF
        /// </summary>
        [JsonProperty("url_arquivo")] public string UrlArquivo { get; set; }

        /// <summary>
        /// Arquivo encodado em base64
        /// </summary>
        [JsonProperty("arquivo")] public string Arquivo { get; set; }

        /// <summary>
        /// Nome do arquivo, sem espaços ou caracteres especiais
        /// </summary>
        [JsonProperty("identificacao_arquivo")] public string IdentificacaoArquivo { get; set; }

        /// <summary>
        /// Extensão do arquivo
        /// </summary>
        [JsonProperty("sufixo_arquivo")] public string SufixoArquivo { get; set; }

        /// <summary>
        /// Indica se terá um quadro de assinatura no comprovante da Assine Bem
        /// </summary>
        [JsonProperty("quadro_assinaturas")] public int QuadroAssinaturas { get; set; }

        /// <summary>
        /// ID único de centro de custo que deve ser vinculado ao documento
        /// </summary>
        [JsonProperty("id_centro_custo")] public int IdCentroCusto { get; set; }

        /// <summary>
        /// obrigatório. Lista das partes envolvidas na assinatura separados por vírgula, vide estrutura <ParteEnvio>.
        /// </summary>
        [JsonProperty("lista_partes")] public List<Parte> ListaPartes { get; set; }
    }
}