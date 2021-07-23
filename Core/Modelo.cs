using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace AssineBem.Core
{
    public class Modelo
    {
        [JsonProperty("dt_criacao")] public string DtCriacao { get; set; }

        [JsonProperty("dt_alteracao")] public string DtAlteracao { get; set; }

        [JsonProperty("nome")] public string Nome { get; set; }

        [JsonProperty("id_externo")] public int IdExterno { get; set; }

        [JsonProperty("partes")] public List<ModeloParte> Partes { get; set; }

        [JsonProperty("campos_avulsos")] public List<ModeloCampo> CamposAvulsos { get; set; }
    }
}