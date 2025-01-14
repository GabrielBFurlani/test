﻿////-----------------------------------------------------------------------
//// <copyright file="SolicitationProductMap.cs" company="Gabriel Furlani">
////  (R) Registrado 2018 Gabriel Furlani.
////  Desenvolvido por Gabriel Furlani.
//// </copyright>
////-----------------------------------------------------------------------
namespace Neomax.Data.Mapping
{
    using FluentNHibernate.Mapping;
    using Neomax.Data.DataAccess;
    using Neomax.Model.Util;

    /// <summary>
    /// Mapping for PasswordDefinition model
    /// </summary>
    public class SolicitationProductMap : ClassMap<SolicitationProductDao>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SolicitationProductMap" /> class.
        /// </summary>
        public SolicitationProductMap()
        {
            this.Table("SolicitacaoProduto");
            this.Id(x => x.Id, "Codigo").GeneratedBy.Identity();
            this.Map(x => x.Title, "Titulo");
            this.Map(x => x.ProductName, "NomeProduto");
            this.Map(x => x.Suggestion, "Sugestao");
            this.Map(x => x.CNPJPayingSource, "CNPJFontePagadora");
            this.Map(x => x.CreationDate, "DataCriacao");
            this.Map(x => x.Status, "Status").CustomType<SolicitationStatus>();
            this.References(x => x.Solicitation, "CodigoSolicitacao");
            this.References(x => x.Product, "CodigoProduto");
            HasManyToMany(x => x.ListDocuments).Table("SolicitacaoProdutoDocumento").ParentKeyColumn("CodigoSolicitacaoProduto").ChildKeyColumn("CodigoDocumento").Cascade.All();
        }
    }
}
