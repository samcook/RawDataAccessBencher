﻿//------------------------------------------------------------------------------
// <auto-generated>This code was generated by LLBLGen Pro v5.6.</auto-generated>
//------------------------------------------------------------------------------
using System;
using System.Collections.Generic;

namespace EFCore.Bencher.EntityClasses
{
	/// <summary>Class which represents the entity 'ProductSubcategory'.</summary>
	public partial class ProductSubcategory : CommonEntityBase
	{
		/// <summary>Method called from the constructor</summary>
		partial void OnCreated();

		/// <summary>Initializes a new instance of the <see cref="ProductSubcategory"/> class.</summary>
		public ProductSubcategory() : base()
		{
			this.Products = new List<Product>();
			OnCreated();
		}

		/// <summary>Gets or sets the ModifiedDate field. </summary>
		public System.DateTime ModifiedDate { get; set;}
		/// <summary>Gets or sets the Name field. </summary>
		public System.String Name { get; set;}
		/// <summary>Gets or sets the ProductCategoryId field. </summary>
		public System.Int32 ProductCategoryId { get; set;}
		/// <summary>Gets or sets the ProductSubcategoryId field. </summary>
		public System.Int32 ProductSubcategoryId { get; set;}
		/// <summary>Gets or sets the Rowguid field. </summary>
		public System.Guid Rowguid { get; set;}
		/// <summary>Represents the navigator which is mapped onto the association 'Product.ProductSubcategory - ProductSubcategory.Products (m:1)'</summary>
		public virtual List<Product> Products { get; set;}
		/// <summary>Represents the navigator which is mapped onto the association 'ProductSubcategory.ProductCategory - ProductCategory.ProductSubcategories (m:1)'</summary>
		public virtual ProductCategory ProductCategory { get; set;}
	}
}