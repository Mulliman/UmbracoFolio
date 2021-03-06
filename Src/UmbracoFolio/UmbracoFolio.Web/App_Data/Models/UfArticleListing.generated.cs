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
	/// <summary>UF.ArticleListing</summary>
	[PublishedModel("ufArticleListing")]
	public partial class UfArticleListing : PublishedElementModel, IUfColumns, IUFlistingSettings, IUfMasonry
	{
		// helpers
#pragma warning disable 0109 // new is redundant
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.10.1")]
		public new const string ModelTypeAlias = "ufArticleListing";
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.10.1")]
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.10.1")]
		public new static IPublishedContentType GetModelContentType()
			=> PublishedModelUtility.GetModelContentType(ModelItemType, ModelTypeAlias);
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.10.1")]
		public static IPublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<UfArticleListing, TValue>> selector)
			=> PublishedModelUtility.GetModelPropertyType(GetModelContentType(), selector);
#pragma warning restore 0109

		// ctor
		public UfArticleListing(IPublishedElement content)
			: base(content)
		{ }

		// properties

		///<summary>
		/// Amount of Columns
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.10.1")]
		[ImplementPropertyType("amountOfColumns")]
		public decimal AmountOfColumns => global::Umbraco.Web.PublishedModels.UfColumns.GetAmountOfColumns(this);

		///<summary>
		/// Amount of Columns on Tablet
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.10.1")]
		[ImplementPropertyType("amountOfColumnsOnTablet")]
		public decimal AmountOfColumnsOnTablet => global::Umbraco.Web.PublishedModels.UfColumns.GetAmountOfColumnsOnTablet(this);

		///<summary>
		/// Button Link Text
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.10.1")]
		[ImplementPropertyType("buttonLinkText")]
		public string ButtonLinkText => global::Umbraco.Web.PublishedModels.UFlistingSettings.GetButtonLinkText(this);

		///<summary>
		/// Do Not Show Date
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.10.1")]
		[ImplementPropertyType("doNotShowDate")]
		public bool DoNotShowDate => global::Umbraco.Web.PublishedModels.UFlistingSettings.GetDoNotShowDate(this);

		///<summary>
		/// Do Not Show Images
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.10.1")]
		[ImplementPropertyType("doNotShowImages")]
		public bool DoNotShowImages => global::Umbraco.Web.PublishedModels.UFlistingSettings.GetDoNotShowImages(this);

		///<summary>
		/// Do Not Show Summary
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.10.1")]
		[ImplementPropertyType("doNotShowSummary")]
		public bool DoNotShowSummary => global::Umbraco.Web.PublishedModels.UFlistingSettings.GetDoNotShowSummary(this);

		///<summary>
		/// Is Masonry
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.10.1")]
		[ImplementPropertyType("isMasonry")]
		public bool IsMasonry => global::Umbraco.Web.PublishedModels.UfMasonry.GetIsMasonry(this);
	}
}
