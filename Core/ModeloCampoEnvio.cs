using Newtonsoft.Json;

namespace AssineBem.Core
{
    public class ModeloCampoEnvio
    {
        [JsonProperty("id_campo")] public int IdCampo { get; set; }
    }
}