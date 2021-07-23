using System.Collections.Generic;
using AssineBem.Enums;
using Newtonsoft.Json;

namespace AssineBem.Core
{
    public class ModeloCampo
    {
        [JsonProperty("id_campo")] public int IdCampo { get; set; }

        [JsonProperty("nome_campo")] public string NomeCampo { get; set; }

        /// <summary>
        /// Formatada sem acento, caractere especial ou espaço e etc. Os espaços são substituídos como '-'
        /// </summary>
        [JsonProperty("label_campo")] public string LabelCampo { get; set; }

        [JsonProperty("preenchimento_obrigatorio")] public int PreenchimentoObrigatorio { get; set; }

        [JsonProperty("id_tipo_campo")] public ModeloTiposCampos IdTipoCampo { get; set; }

        [JsonProperty("descricao_tipo_campo")] public string DescricaoTipoCampo { get; set; }

        [JsonProperty("opcoes")] public List<ModeloCampoOpcoes> Opcoes { get; set; }
    }
}