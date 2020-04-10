﻿//------------------------------------------------------------------------------
// <auto-generated>This code was generated by LLBLGen Pro v5.6.</auto-generated>
//------------------------------------------------------------------------------
using System;
using System.Collections.Generic;

namespace EFCore.Bencher.EntityClasses
{
	/// <summary>Class which represents the entity 'Location'.</summary>
	public partial class Location : CommonEntityBase
	{
		/// <summary>Method called from the constructor</summary>
		partial void OnCreated();

		/// <summary>Initializes a new instance of the <see cref="Location"/> class.</summary>
		public Location() : base()
		{
			this.ProductInventories = new List<ProductInventory>();
			this.WorkOrderRoutings = new List<WorkOrderRouting>();
			OnCreated();
		}

		/// <summary>Gets or sets the Availability field. </summary>
		public System.Decimal Availability { get; set; }
		/// <summary>Gets or sets the CostRate field. </summary>
		public System.Decimal CostRate { get; set; }
		/// <summary>Gets or sets the LocationId field. </summary>
		public System.Int16 LocationId { get; set; }
		/// <summary>Gets or sets the ModifiedDate field. </summary>
		public System.DateTime ModifiedDate { get; set; }
		/// <summary>Gets or sets the Name field. </summary>
		public System.String Name { get; set; }
		/// <summary>Represents the navigator which is mapped onto the association 'ProductInventory.Location - Location.ProductInventories (m:1)'</summary>
		public virtual List<ProductInventory> ProductInventories { get; set; }
		/// <summary>Represents the navigator which is mapped onto the association 'WorkOrderRouting.Location - Location.WorkOrderRoutings (m:1)'</summary>
		public virtual List<WorkOrderRouting> WorkOrderRoutings { get; set; }
	}
}
