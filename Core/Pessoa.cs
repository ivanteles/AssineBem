using System.Collections.Generic;
using Newtonsoft.Json;

namespace AssineBem.Core
{
    public class Pessoa
    {
        [JsonProperty("nome")] public string Nome { get; set; }

        [JsonProperty("rg")] public string Rg { get; set; }

        [JsonProperty("cpf")] public string Cpf { get; set; }

        [JsonProperty("id_tipo_documento")] public string IdTipoDocumento { get; set; }

        [JsonProperty("descricao_documento")] public string DescricaoDocumento { get; set; }

        [JsonProperty("documento")] public string Documento { get; set; }

        [JsonProperty("emails")] public PessoaEmail Emails { get; set; }

        [JsonProperty("telefones")] public List<PessoaTelefone> Telefones { get; set; }
    }
}