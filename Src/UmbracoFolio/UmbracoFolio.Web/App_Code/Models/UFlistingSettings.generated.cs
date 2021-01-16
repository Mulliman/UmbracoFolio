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
	// Mixin Content Type with alias "uFListingSettings"
	/// <summary>UF.ListingSettings</summary>
	public partial interface IUFlistingSettings : IPublishedElement
	{
		/// <summary>Button Link Text</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.10.1")]
		string ButtonLinkText { get; }

		/// <summary>Do Not Show Date</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.10.1")]
		bool DoNotShowDate { get; }

		/// <summary>Do Not Show Images</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.10.1")]
		bool DoNotShowImages { get; }

		/// <summary>Do Not Show Summary</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.10.1")]
		bool DoNotShowSummary { get; }
	}

	/// <summary>UF.ListingSettings</summary>
	[PublishedModel("uFListingSettings")]
	public partial class UFlistingSettings : PublishedElementModel, IUFlistingSettings
	{
		// helpers
#pragma warning disable 0109 // new is redundant
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.10.1")]
		public new const string ModelTypeAlias = "uFListingSettings";
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.10.1")]
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.10.1")]
		public new static IPublishedContentType GetModelContentType()
			=> PublishedModelUtility.GetModelContentType(ModelItemType, ModelTypeAlias);
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.10.1")]
		public static IPublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<UFlistingSettings, TValue>> selector)
			=> PublishedModelUtility.GetModelPropertyType(GetModelContentType(), selector);
#pragma warning restore 0109

		// ctor
		public UFlistingSettings(IPublishedElement content)
			: base(content)
		{ }

		// properties

		///<summary>
		/// Button Link Text
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.10.1")]
		[ImplementPropertyType("buttonLinkText")]
		public string ButtonLinkText => GetButtonLinkText(this);

		/// <summary>Static getter for Button Link Text</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.10.1")]
		public static string GetButtonLinkText(IUFlistingSettings that) => that.Value<string>("buttonLinkText");

		///<summary>
		/// Do Not Show Date
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.10.1")]
		[ImplementPropertyType("doNotShowDate")]
		public bool DoNotShowDate => GetDoNotShowDate(this);

		/// <summary>Static getter for Do Not Show Date</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.10.1")]
		public static bool GetDoNotShowDate(IUFlistingSettings that) => that.Value<bool>("doNotShowDate");

		///<summary>
		/// Do Not Show Images
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.10.1")]
		[ImplementPropertyType("doNotShowImages")]
		public bool DoNotShowImages => GetDoNotShowImages(this);

		/// <summary>Static getter for Do Not Show Images</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.10.1")]
		public static bool GetDoNotShowImages(IUFlistingSettings that) => that.Value<bool>("doNotShowImages");

		///<summary>
		/// Do Not Show Summary
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.10.1")]
		[ImplementPropertyType("doNotShowSummary")]
		public bool DoNotShowSummary => GetDoNotShowSummary(this);

		/// <summary>Static getter for Do Not Show Summary</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.10.1")]
		public static bool GetDoNotShowSummary(IUFlistingSettings that) => that.Value<bool>("doNotShowSummary");
	}
}
