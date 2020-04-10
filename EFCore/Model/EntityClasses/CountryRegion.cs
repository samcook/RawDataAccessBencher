﻿//------------------------------------------------------------------------------
// <auto-generated>This code was generated by LLBLGen Pro v5.6.</auto-generated>
//------------------------------------------------------------------------------
using System;
using System.Collections.Generic;

namespace EFCore.Bencher.EntityClasses
{
	/// <summary>Class which represents the entity 'CountryRegion'.</summary>
	public partial class CountryRegion : CommonEntityBase
	{
		/// <summary>Method called from the constructor</summary>
		partial void OnCreated();

		/// <summary>Initializes a new instance of the <see cref="CountryRegion"/> class.</summary>
		public CountryRegion() : base()
		{
			this.CountryRegionCurrencies = new List<CountryRegionCurrency>();
			this.SalesTerritories = new List<SalesTerritory>();
			this.StateProvinces = new List<StateProvince>();
			OnCreated();
		}

		/// <summary>Gets or sets the CountryRegionCode field. </summary>
		public System.String CountryRegionCode { get; set; }
		/// <summary>Gets or sets the ModifiedDate field. </summary>
		public System.DateTime ModifiedDate { get; set; }
		/// <summary>Gets or sets the Name field. </summary>
		public System.String Name { get; set; }
		/// <summary>Represents the navigator which is mapped onto the association 'CountryRegionCurrency.CountryRegion - CountryRegion.CountryRegionCurrencies (m:1)'</summary>
		public virtual List<CountryRegionCurrency> CountryRegionCurrencies { get; set; }
		/// <summary>Represents the navigator which is mapped onto the association 'SalesTerritory.CountryRegion - CountryRegion.SalesTerritories (m:1)'</summary>
		public virtual List<SalesTerritory> SalesTerritories { get; set; }
		/// <summary>Represents the navigator which is mapped onto the association 'StateProvince.CountryRegion - CountryRegion.StateProvinces (m:1)'</summary>
		public virtual List<StateProvince> StateProvinces { get; set; }
	}
}
