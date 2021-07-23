using System;
using Newtonsoft.Json;

namespace AssineBem.Core
{
    public class ParteUrl
    {
        /// <summary>
        /// URL completa para acesso ao sistema pelo assinante.
        /// </summary>
        [JsonProperty("url")] public string Url { get; set; }

        /// <summary>
        /// Token UUID para acesso ao sistema com expiração.
        /// </summary>
        [JsonProperty("token")] public string Token { get; set; }

        /// <summary>
        /// Opcional com valor 0 ou 1. Se a URL for de assinatura, este parâmetro retorna 1.
        /// </summary>
        [JsonProperty("assinatura")] public string Assinatura { get; set; }

        /// <summary>
        /// Opcional com valor 0 ou 1. Se a URL for de validação, este parâmetro retorna 1.
        /// </summary>
        [JsonProperty("validacao")] public string Validacao { get; set; }

        /// <summary>
        /// Data de expiração do Token quando for URL de acesso para assinatura.
        /// </summary>
        [JsonProperty("dt_expiracao_token")] public string DtExpiracaoToken { get; set; }
    }
}