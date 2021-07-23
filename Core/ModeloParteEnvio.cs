using Newtonsoft.Json;

namespace AssineBem.Core
{
    public class ModeloParteEnvio
    {
        [JsonProperty("id_modelo_parte")] public int IdModeloParte { get; set; }
    }
}