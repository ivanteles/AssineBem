using System;
using Newtonsoft.Json;

namespace AssineBem.Core
{
    public class AssinaturaParte
    {
        [JsonProperty("dt_criado")] public string DtCriado { get; set; }

        [JsonProperty("dt_visualizado")] public string DtVisualizado { get; set; }

        [JsonProperty("dt_assinado")] public string DtAssinado { get; set; }

        [JsonProperty("id_externo")] public int IdExterno { get; set; }

        [JsonProperty("identificador_assinatura")] public string IdentificadorAssinatura { get; set; }
    }
}