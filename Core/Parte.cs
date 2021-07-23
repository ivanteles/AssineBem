using System;
using System.Collections.Generic;
using AssineBem.Enums;
using AssineBem.Tabelas;
using Newtonsoft.Json;

namespace AssineBem.Core
{
    public class Parte
    {
        /// <summary>
        ///     obrigatório
        /// </summary>
        [JsonProperty("id_validacao_bloco")] public ValidacoesBlocos IdValidacaoBloco { get; set; }
        [JsonProperty("id_externo")] public string IdExterno { get; set; }
        [JsonProperty("dt_criacao")] public string DtCriacao { get; set; }
        [JsonProperty("dt_ult_notificado")] public string DtUltNotificado { get; set; }
        [JsonProperty("id_status_pessoa_parte")] public int IdStatusPessoaParte { get; set; }
        [JsonProperty("descricao_parte_status")] public string DescricaoParteStatus { get; set; }
        [JsonProperty("pessoa")] public Pessoa Pessoa { get; set; }

        /// <summary>
        ///     obrigatório
        /// </summary>
        [JsonProperty("nome")] public string Nome { get; set; }

        /// <summary>
        ///     obrigatório
        /// </summary>
        [JsonProperty("rg")] public string Rg { get; set; }

        /// <summary>
        ///     obrigatório
        /// </summary>
        [JsonProperty("cpf")] public string Cpf { get; set; }

        /// <summary>
        ///     obrigatório
        /// </summary>
        [JsonProperty("id_tipo_documento")] public TipoDocumento IdTipoDocumento { get; set; }

        /// <summary>
        ///     obrigatório. descrição para a parte sobre qual documento está sendo utilizado para identificação. Exemplo: Passaporte, código interno e etc...
        /// </summary>
        [JsonProperty("descricao_documento")] public string DescricaoDocumento { get; set; }

        /// <summary>
        ///     obrigatório. Valor do documento para cada parte. Exemplo: número do passaporte da pessoa ou código interno pré-combinado com a parte.
        /// </summary>
        [JsonProperty("documento")] public string Documento { get; set; }

        /// <summary>
        ///     obrigatório
        /// </summary>
        [JsonProperty("email")] public string Email { get; set; }

        /// <summary>
        ///     obrigatório
        /// </summary>
        [JsonProperty("ddd")] public int Ddd { get; set; }

        /// <summary>
        ///     obrigatório
        /// </summary>
        [JsonProperty("telefone")] public int Telefone { get; set; }

        /// <summary>
        ///     obrigatório
        /// </summary>
        [JsonProperty("id_tipo_telefone")] public TelefonesTipo TipoTelefone { get; set; }

        /// <summary>
        ///     obrigatório. Ex.: Locador, Locatário, Estagiário, Empresa concedente, etc.
        /// </summary>
        [JsonProperty("identificacao_parte")] public string IdentificacaoParte { get; set; }

        /// <summary>
        ///     obrigatório. Identificação da parte no sistema de origem dos dados.
        /// </summary>
        [JsonProperty("id_referencia")] public string IdReferencia { get; set; }

        /// <summary>
        ///     opcional. Array com as ações da parte no documento. Parâmetro opcional, o padrão é sempre ASSINAR e VISUALIZAR.
        /// </summary>
        [JsonProperty("acoes")] public List<ParteAcoes> Acoes { get; set; }

        /// <summary>
        ///     opcional. Indicar ordem de assinaturas, assinam do menor para o maior, o padrão é sempre 0, ou seja, assinam
        ///     primeiro.
        /// </summary>
        [JsonProperty("ordem_assinatura")] public int OrdemAssinatura { get; set; }

        /// <summary>
        ///     opcional, default é Sim
        /// </summary>
        [JsonProperty("notificar")] public Notificar Notificar { get; set; }

        /// <summary>
        ///     opcional. Define que a parte deve preencher os dados pela Assine Bem antes de realizar Assinatura, portanto não é
        ///     necessário enviar os dados obrigatórios como CPF, RG. Para utilizar esta opção, o valor deste parâmetro deve ser 1
        ///     e o produto estar configurado e disponível para a sua conta.
        /// </summary>
        [JsonProperty("pessoa_preenche_dados")] public string PessoaPreencheDados { get; set; }

        /// <summary>
        ///     opcional. Se a parte assina um modelo e o solicitante deseja validar os campos preenchidos antes de efetivar a
        ///     assinatura, o valor deve ser 1.
        /// </summary>
        [JsonProperty("validar_campos")] public string ValidarCampos { get; set; }

        /// <summary>
        ///     opcional. Se a parte assina um modelo e possui anexos no processo de assinatura, e o solicitante deseja validar os
        ///     anexos enviados, o valor deve ser 1.
        /// </summary>
        [JsonProperty("validar_anexos")] public string ValidarAnexos { get; set; }

        /// <summary>
        ///     opcional. Estrutura ParteRedirecionamento para configurar redirecionamentos da parte durante processo de assinatura
        ///     digital. Essa estrutura depende de um produto extra que necessita liberação da equipe da Assine Bem para
        ///     utilização.
        /// </summary>
        [JsonProperty("redirecionamentos")] public List<TiposRedirecionamentos> Redirecionamentos { get; set; }
    }
}