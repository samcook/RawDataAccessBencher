﻿//------------------------------------------------------------------------------
// <auto-generated>This code was generated by LLBLGen Pro v5.6.</auto-generated>
//------------------------------------------------------------------------------
using System;
using System.Collections.Generic;

namespace EFCore.Bencher.EntityClasses
{
	/// <summary>Class which represents the entity 'TransactionHistoryArchive'.</summary>
	public partial class TransactionHistoryArchive : CommonEntityBase
	{
		/// <summary>Method called from the constructor</summary>
		partial void OnCreated();

		/// <summary>Initializes a new instance of the <see cref="TransactionHistoryArchive"/> class.</summary>
		public TransactionHistoryArchive() : base()
		{
			OnCreated();
		}

		/// <summary>Gets or sets the ActualCost field. </summary>
		public System.Decimal ActualCost { get; set; }
		/// <summary>Gets or sets the ModifiedDate field. </summary>
		public System.DateTime ModifiedDate { get; set; }
		/// <summary>Gets or sets the ProductId field. </summary>
		public System.Int32 ProductId { get; set; }
		/// <summary>Gets or sets the Quantity field. </summary>
		public System.Int32 Quantity { get; set; }
		/// <summary>Gets or sets the ReferenceOrderId field. </summary>
		public System.Int32 ReferenceOrderId { get; set; }
		/// <summary>Gets or sets the ReferenceOrderLineId field. </summary>
		public System.Int32 ReferenceOrderLineId { get; set; }
		/// <summary>Gets or sets the TransactionDate field. </summary>
		public System.DateTime TransactionDate { get; set; }
		/// <summary>Gets or sets the TransactionId field. </summary>
		public System.Int32 TransactionId { get; set; }
		/// <summary>Gets or sets the TransactionType field. </summary>
		public System.String TransactionType { get; set; }
	}
}
