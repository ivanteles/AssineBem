using Newtonsoft.Json;

namespace AssineBem.Core
{
    public class AdicionarParte
    {
        [JsonProperty("id_validacao_bloco")] public long IdValidacaoBloco { get; set; }

        /// <summary>
        ///     ID que foi retornado ao criar a parte
        /// </summary>
        [JsonProperty("id_externo")]
        public string IdExterno { get; set; }

        [JsonProperty("identificacao_parte")] public string IdentificacaoParte { get; set; }

        /// <summary>
        ///     Identificação da parte no sistema de origem dos dados
        /// </summary>
        [JsonProperty("id_referencia")]
        public string IdReferencia { get; set; }

        /// <summary>
        ///     Indicar ordem de assinaturas, assinam do menor para o maior, o padrão é sempre 0, ou seja, assina primeiro.
        /// </summary>
        [JsonProperty("ordem_assinatura")]
        public int OrdemAssinatura { get; set; }
    }
}