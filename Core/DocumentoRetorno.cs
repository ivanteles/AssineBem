using Newtonsoft.Json;

namespace AssineBem.Core
{
    public class DocumentoRetorno
    {
        [JsonProperty("mensagem")] public string Mensagem { get; set; }

        [JsonProperty("status")] public int Status { get; set; }

        [JsonProperty("documento")] public Documento Documento { get; set; }
    }
}