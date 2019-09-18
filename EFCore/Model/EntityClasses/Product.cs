﻿//------------------------------------------------------------------------------
// <auto-generated>This code was generated by LLBLGen Pro v5.6.</auto-generated>
//------------------------------------------------------------------------------
using System;
using System.Collections.Generic;

namespace EFCore.Bencher.EntityClasses
{
	/// <summary>Class which represents the entity 'Product'.</summary>
	public partial class Product : CommonEntityBase
	{
		/// <summary>Method called from the constructor</summary>
		partial void OnCreated();

		/// <summary>Initializes a new instance of the <see cref="Product"/> class.</summary>
		public Product() : base()
		{
			this.BillOfMaterials = new List<BillOfMaterial>();
			this.BillOfMaterials_ = new List<BillOfMaterial>();
			this.ProductCostHistories = new List<ProductCostHistory>();
			this.ProductDocuments = new List<ProductDocument>();
			this.ProductInventories = new List<ProductInventory>();
			this.ProductListPriceHistories = new List<ProductListPriceHistory>();
			this.ProductProductPhotos = new List<ProductProductPhoto>();
			this.ProductReviews = new List<ProductReview>();
			this.ProductVendors = new List<ProductVendor>();
			this.PurchaseOrderDetails = new List<PurchaseOrderDetail>();
			this.ShoppingCartItems = new List<ShoppingCartItem>();
			this.SpecialOfferProducts = new List<SpecialOfferProduct>();
			this.TransactionHistories = new List<TransactionHistory>();
			this.WorkOrders = new List<WorkOrder>();
			OnCreated();
		}

		/// <summary>Gets or sets the Class field. </summary>
		public System.String Class { get; set;}
		/// <summary>Gets or sets the Color field. </summary>
		public System.String Color { get; set;}
		/// <summary>Gets or sets the DaysToManufacture field. </summary>
		public System.Int32 DaysToManufacture { get; set;}
		/// <summary>Gets or sets the DiscontinuedDate field. </summary>
		public Nullable<System.DateTime> DiscontinuedDate { get; set;}
		/// <summary>Gets or sets the FinishedGoodsFlag field. </summary>
		public System.Boolean FinishedGoodsFlag { get; set;}
		/// <summary>Gets or sets the ListPrice field. </summary>
		public System.Decimal ListPrice { get; set;}
		/// <summary>Gets or sets the MakeFlag field. </summary>
		public System.Boolean MakeFlag { get; set;}
		/// <summary>Gets or sets the ModifiedDate field. </summary>
		public System.DateTime ModifiedDate { get; set;}
		/// <summary>Gets or sets the Name field. </summary>
		public System.String Name { get; set;}
		/// <summary>Gets or sets the ProductId field. </summary>
		public System.Int32 ProductId { get; set;}
		/// <summary>Gets or sets the ProductLine field. </summary>
		public System.String ProductLine { get; set;}
		/// <summary>Gets or sets the ProductModelId field. </summary>
		public Nullable<System.Int32> ProductModelId { get; set;}
		/// <summary>Gets or sets the ProductNumber field. </summary>
		public System.String ProductNumber { get; set;}
		/// <summary>Gets or sets the ProductSubcategoryId field. </summary>
		public Nullable<System.Int32> ProductSubcategoryId { get; set;}
		/// <summary>Gets or sets the ReorderPoint field. </summary>
		public System.Int16 ReorderPoint { get; set;}
		/// <summary>Gets or sets the Rowguid field. </summary>
		public System.Guid Rowguid { get; set;}
		/// <summary>Gets or sets the SafetyStockLevel field. </summary>
		public System.Int16 SafetyStockLevel { get; set;}
		/// <summary>Gets or sets the SellEndDate field. </summary>
		public Nullable<System.DateTime> SellEndDate { get; set;}
		/// <summary>Gets or sets the SellStartDate field. </summary>
		public System.DateTime SellStartDate { get; set;}
		/// <summary>Gets or sets the Size field. </summary>
		public System.String Size { get; set;}
		/// <summary>Gets or sets the SizeUnitMeasureCode field. </summary>
		public System.String SizeUnitMeasureCode { get; set;}
		/// <summary>Gets or sets the StandardCost field. </summary>
		public System.Decimal StandardCost { get; set;}
		/// <summary>Gets or sets the Style field. </summary>
		public System.String Style { get; set;}
		/// <summary>Gets or sets the Weight field. </summary>
		public Nullable<System.Decimal> Weight { get; set;}
		/// <summary>Gets or sets the WeightUnitMeasureCode field. </summary>
		public System.String WeightUnitMeasureCode { get; set;}
		/// <summary>Represents the navigator which is mapped onto the association 'BillOfMaterial.Product - Product.BillOfMaterials (m:1)'</summary>
		public virtual List<BillOfMaterial> BillOfMaterials { get; set;}
		/// <summary>Represents the navigator which is mapped onto the association 'BillOfMaterial.Product_ - Product.BillOfMaterials_ (m:1)'</summary>
		public virtual List<BillOfMaterial> BillOfMaterials_ { get; set;}
		/// <summary>Represents the navigator which is mapped onto the association 'ProductCostHistory.Product - Product.ProductCostHistories (m:1)'</summary>
		public virtual List<ProductCostHistory> ProductCostHistories { get; set;}
		/// <summary>Represents the navigator which is mapped onto the association 'ProductDocument.Product - Product.ProductDocuments (m:1)'</summary>
		public virtual List<ProductDocument> ProductDocuments { get; set;}
		/// <summary>Represents the navigator which is mapped onto the association 'ProductInventory.Product - Product.ProductInventories (m:1)'</summary>
		public virtual List<ProductInventory> ProductInventories { get; set;}
		/// <summary>Represents the navigator which is mapped onto the association 'ProductListPriceHistory.Product - Product.ProductListPriceHistories (m:1)'</summary>
		public virtual List<ProductListPriceHistory> ProductListPriceHistories { get; set;}
		/// <summary>Represents the navigator which is mapped onto the association 'Product.ProductModel - ProductModel.Products (m:1)'</summary>
		public virtual ProductModel ProductModel { get; set;}
		/// <summary>Represents the navigator which is mapped onto the association 'ProductProductPhoto.Product - Product.ProductProductPhotos (m:1)'</summary>
		public virtual List<ProductProductPhoto> ProductProductPhotos { get; set;}
		/// <summary>Represents the navigator which is mapped onto the association 'ProductReview.Product - Product.ProductReviews (m:1)'</summary>
		public virtual List<ProductReview> ProductReviews { get; set;}
		/// <summary>Represents the navigator which is mapped onto the association 'Product.ProductSubcategory - ProductSubcategory.Products (m:1)'</summary>
		public virtual ProductSubcategory ProductSubcategory { get; set;}
		/// <summary>Represents the navigator which is mapped onto the association 'ProductVendor.Product - Product.ProductVendors (m:1)'</summary>
		public virtual List<ProductVendor> ProductVendors { get; set;}
		/// <summary>Represents the navigator which is mapped onto the association 'PurchaseOrderDetail.Product - Product.PurchaseOrderDetails (m:1)'</summary>
		public virtual List<PurchaseOrderDetail> PurchaseOrderDetails { get; set;}
		/// <summary>Represents the navigator which is mapped onto the association 'ShoppingCartItem.Product - Product.ShoppingCartItems (m:1)'</summary>
		public virtual List<ShoppingCartItem> ShoppingCartItems { get; set;}
		/// <summary>Represents the navigator which is mapped onto the association 'SpecialOfferProduct.Product - Product.SpecialOfferProducts (m:1)'</summary>
		public virtual List<SpecialOfferProduct> SpecialOfferProducts { get; set;}
		/// <summary>Represents the navigator which is mapped onto the association 'TransactionHistory.Product - Product.TransactionHistories (m:1)'</summary>
		public virtual List<TransactionHistory> TransactionHistories { get; set;}
		/// <summary>Represents the navigator which is mapped onto the association 'Product.UnitMeasure - UnitMeasure.Products (m:1)'</summary>
		public virtual UnitMeasure UnitMeasure { get; set;}
		/// <summary>Represents the navigator which is mapped onto the association 'Product.UnitMeasure_ - UnitMeasure.Products_ (m:1)'</summary>
		public virtual UnitMeasure UnitMeasure_ { get; set;}
		/// <summary>Represents the navigator which is mapped onto the association 'WorkOrder.Product - Product.WorkOrders (m:1)'</summary>
		public virtual List<WorkOrder> WorkOrders { get; set;}
	}
}