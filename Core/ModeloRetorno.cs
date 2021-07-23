using Newtonsoft.Json;

namespace AssineBem.Core
{
    public class ModeloRetorno
    {
        [JsonProperty("modelo")] public Modelo Modelo { get; set; }
    }
}