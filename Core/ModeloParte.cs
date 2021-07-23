using Newtonsoft.Json;

namespace AssineBem.Core
{
    public class ModeloParte
    {
        [JsonProperty("id_modelo_parte")] public int IdModeloParte { get; set; }

        [JsonProperty("identificacao_parte")] public string IdentificacaoParte { get; set; }

        [JsonProperty("anexos")] public int Anexos { get; set; }
    }
}