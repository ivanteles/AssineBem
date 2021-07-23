using System;
using System.Collections.Generic;
using AssineBem.Enums;
using Newtonsoft.Json;

namespace AssineBem.Core
{
    public class ParteRetorno
    {
        /// <summary>
        ///     Só retorna se tiver valor
        /// </summary>
        [JsonProperty("id_referencia")] public string IdReferencia { get; set; }

        [JsonProperty("id_externo")] public string IdExterno { get; set; }

        [JsonProperty("id_status_pessoa_parte")] public PessoasPartesStatus IdStatusPessoaParte { get; set; }

        [JsonProperty("descricao_parte_status")] public string DescricaoParteStatus { get; set; }

        [JsonProperty("identificacao_parte")] public string IdentificacaoParte { get; set; }

        [JsonProperty("dt_ult_notificado")] public string DtUltNotificado { get; set; }

        [JsonProperty("dt_criacao")] public string DtCriacao { get; set; }

        [JsonProperty("pessoa")] public Pessoa Pessoa { get; set; }

        [JsonProperty("parte_url")] public List<ParteUrl> ParteUrl { get; set; }
    }
}