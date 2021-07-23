using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace AssineBem.Core
{
    public class Documento
    {
        [JsonProperty("id_servico")] public int IdServico { get; set; }
        [JsonProperty("id_documento_status")] public int IdDocumentoStatus { get; set; }

        [JsonProperty("descricao_documento_status")] public string DescricaoDocumentoStatus { get; set; }

        [JsonProperty("identificacao_arquivo")] public string IdentificacaoArquivo { get; set; }

        [JsonProperty("nome_arquivo")] public string NomeArquivo { get; set; }

        [JsonProperty("dt_criacao")] public string DtCriacao { get; set; }

        [JsonProperty("id_externo")] public string IdExterno { get; set; }

        [JsonProperty("identificador_documento")] public string IdentificadorDocumento { get; set; }

        [JsonProperty("nome_arquivo_assinado")] public string NomeArquivoAssinado { get; set; }

        [JsonProperty("quadro_assinaturas")] public string QuadroAssinaturas { get; set; }

        [JsonProperty("hash_arquivo")] public string HashArquivo { get; set; }

        [JsonProperty("lista_partes")] public List<Parte> ListaPartes { get; set; }
    }
}