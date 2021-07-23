using Newtonsoft.Json;

namespace AssineBem.Core
{
    public class ModeloCampoOpcoes
    {
        [JsonProperty("id_opcao")] public int IdOpcao { get; set; }

        [JsonProperty("opcao")] public string Opcao { get; set; }

    }
}