using System;
using AssineBem.Tabelas;
using Newtonsoft.Json;

namespace AssineBem.Core
{
    public class ParteRedirecionamento
    {
        [JsonProperty("tipo")] public TiposRedirecionamentos Tipo { get; set; }

        /// <summary>
        /// URL para onde a parte será redirecionada. A URL deve ser com protocolo https e estar liberada na whitelist da Assine Bem. Para isso, é preciso enviar a solicitação de adicionar a URL para a equipe comercial.
        /// </summary>
        [JsonProperty("url")] public string Url { get; set; }

        /// <summary>
        /// String JSON key-value pair com os parâmetros que devem ser enviados juntos com a URL durante o redirecionamento. Exemplo: {'PARAM1': 'VAL_PARAM1'}
        /// </summary>
        [JsonProperty("parametros")] public string Parametros { get; set; }
    }
}