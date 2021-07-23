using System;
using Newtonsoft.Json;

namespace AssineBem.Core
{
    public class PessoaEmail
    {
        [JsonProperty("id_pessoa_status_email")] public int IdPessoaStatusEmail { get; set; }
        [JsonProperty("email")] public string Email { get; set; }

        [JsonProperty("descricao_status_email")] public string DescricaoStatusEmail { get; set; }
        [JsonProperty("data_atualizacao_status")] public string DataAtualizacaoStatus { get; set; }

        [JsonProperty("data_criacao")] public string DataCriacao { get; set; }
    }
}