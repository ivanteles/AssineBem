using System;
using Newtonsoft.Json;

namespace AssineBem.Core
{
    public class PessoaTelefone
    {
        [JsonProperty("ddd")] public int Ddd { get; set; }

        [JsonProperty("telefone")] public int Telefone { get; set; }

        [JsonProperty("id_pessoa_tipo_telefone")] public string IdPessoaTipoTelefone { get; set; }

        [JsonProperty("descricao_status_telefone")] public string DescricaoStatusTelefone { get; set; }

        [JsonProperty("descricao_tipo_telefone")] public string DescricaoTipoTelefone { get; set; }

        [JsonProperty("data_criacao")] public string DataCriacao { get; set; }
    }
}