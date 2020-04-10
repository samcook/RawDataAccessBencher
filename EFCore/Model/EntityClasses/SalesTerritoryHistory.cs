﻿//------------------------------------------------------------------------------
// <auto-generated>This code was generated by LLBLGen Pro v5.6.</auto-generated>
//------------------------------------------------------------------------------
using System;
using System.Collections.Generic;

namespace EFCore.Bencher.EntityClasses
{
	/// <summary>Class which represents the entity 'SalesTerritoryHistory'.</summary>
	public partial class SalesTerritoryHistory : CommonEntityBase
	{
		/// <summary>Method called from the constructor</summary>
		partial void OnCreated();

		/// <summary>Initializes a new instance of the <see cref="SalesTerritoryHistory"/> class.</summary>
		public SalesTerritoryHistory() : base()
		{
			OnCreated();
		}

		/// <summary>Gets or sets the EndDate field. </summary>
		public Nullable<System.DateTime> EndDate { get; set; }
		/// <summary>Gets or sets the ModifiedDate field. </summary>
		public System.DateTime ModifiedDate { get; set; }
		/// <summary>Gets or sets the Rowguid field. </summary>
		public System.Guid Rowguid { get; set; }
		/// <summary>Gets or sets the SalesPersonId field. </summary>
		public System.Int32 SalesPersonId { get; set; }
		/// <summary>Gets or sets the StartDate field. </summary>
		public System.DateTime StartDate { get; set; }
		/// <summary>Gets or sets the TerritoryId field. </summary>
		public System.Int32 TerritoryId { get; set; }
		/// <summary>Represents the navigator which is mapped onto the association 'SalesTerritoryHistory.SalesPerson - SalesPerson.SalesTerritoryHistories (m:1)'</summary>
		public virtual SalesPerson SalesPerson { get; set; }
		/// <summary>Represents the navigator which is mapped onto the association 'SalesTerritoryHistory.SalesTerritory - SalesTerritory.SalesTerritoryHistories (m:1)'</summary>
		public virtual SalesTerritory SalesTerritory { get; set; }
	}
}
