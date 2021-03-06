//------------------------------------------------------------------------------
// <auto-generated>
//   This code was generated by a tool.
//
//    Umbraco.ModelsBuilder.Embedded v8.10.1
//
//   Changes to this file will be lost if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Web;
using Umbraco.Core.Models;
using Umbraco.Core.Models.PublishedContent;
using Umbraco.Web;
using Umbraco.ModelsBuilder.Embedded;

namespace Umbraco.Web.PublishedModels
{
	// Mixin Content Type with alias "ufColumns"
	/// <summary>UF.Columns</summary>
	public partial interface IUfColumns : IPublishedElement
	{
		/// <summary>Amount of Columns</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.10.1")]
		decimal AmountOfColumns { get; }

		/// <summary>Amount of Columns on Tablet</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.10.1")]
		decimal AmountOfColumnsOnTablet { get; }
	}

	/// <summary>UF.Columns</summary>
	[PublishedModel("ufColumns")]
	public partial class UfColumns : PublishedElementModel, IUfColumns
	{
		// helpers
#pragma warning disable 0109 // new is redundant
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.10.1")]
		public new const string ModelTypeAlias = "ufColumns";
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.10.1")]
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.10.1")]
		public new static IPublishedContentType GetModelContentType()
			=> PublishedModelUtility.GetModelContentType(ModelItemType, ModelTypeAlias);
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.10.1")]
		public static IPublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<UfColumns, TValue>> selector)
			=> PublishedModelUtility.GetModelPropertyType(GetModelContentType(), selector);
#pragma warning restore 0109

		// ctor
		public UfColumns(IPublishedElement content)
			: base(content)
		{ }

		// properties

		///<summary>
		/// Amount of Columns
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.10.1")]
		[ImplementPropertyType("amountOfColumns")]
		public decimal AmountOfColumns => GetAmountOfColumns(this);

		/// <summary>Static getter for Amount of Columns</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.10.1")]
		public static decimal GetAmountOfColumns(IUfColumns that) => that.Value<decimal>("amountOfColumns");

		///<summary>
		/// Amount of Columns on Tablet
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.10.1")]
		[ImplementPropertyType("amountOfColumnsOnTablet")]
		public decimal AmountOfColumnsOnTablet => GetAmountOfColumnsOnTablet(this);

		/// <summary>Static getter for Amount of Columns on Tablet</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.10.1")]
		public static decimal GetAmountOfColumnsOnTablet(IUfColumns that) => that.Value<decimal>("amountOfColumnsOnTablet");
	}
}
