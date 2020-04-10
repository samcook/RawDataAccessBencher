﻿//------------------------------------------------------------------------------
// <auto-generated>This code was generated by LLBLGen Pro v5.6.</auto-generated>
//------------------------------------------------------------------------------
using System;
using System.Collections.Generic;

namespace EFCore.Bencher.EntityClasses
{
	/// <summary>Class which represents the entity 'CountryRegionCurrency'.</summary>
	public partial class CountryRegionCurrency : CommonEntityBase
	{
		/// <summary>Method called from the constructor</summary>
		partial void OnCreated();

		/// <summary>Initializes a new instance of the <see cref="CountryRegionCurrency"/> class.</summary>
		public CountryRegionCurrency() : base()
		{
			OnCreated();
		}

		/// <summary>Gets or sets the CountryRegionCode field. </summary>
		public System.String CountryRegionCode { get; set; }
		/// <summary>Gets or sets the CurrencyCode field. </summary>
		public System.String CurrencyCode { get; set; }
		/// <summary>Gets or sets the ModifiedDate field. </summary>
		public System.DateTime ModifiedDate { get; set; }
		/// <summary>Represents the navigator which is mapped onto the association 'CountryRegionCurrency.CountryRegion - CountryRegion.CountryRegionCurrencies (m:1)'</summary>
		public virtual CountryRegion CountryRegion { get; set; }
		/// <summary>Represents the navigator which is mapped onto the association 'CountryRegionCurrency.Currency - Currency.CountryRegionCurrencies (m:1)'</summary>
		public virtual Currency Currency { get; set; }
	}
}
