using Newtonsoft.Json;

namespace AssineBem
{
    public class Retorno
    {
        [JsonProperty("identifier")] public string Identifier { get; set; }
        [JsonProperty("status")] public int Status { get; set; }
        [JsonProperty("mensagem")] public string Mensagem { get; set; }
}
}