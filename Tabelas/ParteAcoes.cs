using Newtonsoft.Json;

namespace AssineBem.Tabelas
{
    public class ParteAcoes
    {
        [JsonProperty("assinar")] public string Assinar { get; set; }
        [JsonProperty("visualizar")] public string Visualizar { get; set; }
        [JsonProperty("rubricar")] public string Rubricar { get; set; }
    }
}