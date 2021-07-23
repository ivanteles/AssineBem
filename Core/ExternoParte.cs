using System;
using Newtonsoft.Json;

namespace AssineBem.Core
{
    public class ExternoParte
    {
        [JsonProperty("identificacao_anexo")] public string IdentificacaoAnexo { get; set; }

        /// <summary>
        /// Este parâmetro identifica se o envio do anexo é ou não obrigatório. Retorno 1 se obrigatório, 0 se não obrigatório.
        /// </summary>
        [JsonProperty("envio_obrigatorio")] public int EnvioObrigatorio { get; set; }

        /// <summary>
        /// Este parâmetro identifica se o anexo foi enviado. Retorno 1 se foi enviado, 0 se não foi enviado.
        /// </summary>
        [JsonProperty("enviado")] public int Enviado { get; set; }

        /// <summary>
        /// Este parâmetro identifica o status do anexo enviado. Pode ser 1 (Pendente) ou 2 (Aprovado) ou 3 (Inválido) ou 4 (Não enviado)
        /// </summary>
        [JsonProperty("status")] public int Status { get; set; }

        [JsonProperty("descricao_status")] public string DescricaoStatus { get; set; }

        [JsonProperty("dt_enviado")] public string DtEnviado { get; set; }

        /// <summary>
        /// Este parâmetro só é retornado se (enviado = 1) e utiliza-o para fazer download do anexo no Endpoint "documento/anexos/download"
        /// </summary>
        [JsonProperty("id_download")] public int IdDownload { get; set; }
    }
}