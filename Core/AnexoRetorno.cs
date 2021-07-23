using System.Collections.Generic;
using Newtonsoft.Json;

namespace AssineBem.Core
{
    public class AnexoRetorno
    {
        [JsonProperty("id_externo_parte")]
        public List<ExternoParte> ExternoParte { get; set; }
    }
}