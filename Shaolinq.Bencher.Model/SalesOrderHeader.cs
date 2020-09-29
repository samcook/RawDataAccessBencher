using System;
using Platform.Validation;

namespace Shaolinq.Bencher.Model
{
	[DataAccessObject]
	public abstract class SalesOrderHeader : DataAccessObject<int>
	{
		[PersistedMember(Name = "SalesOrderID")]
		public abstract override int Id { get; set; }

		[PersistedMember]
		public abstract string AccountNumber { get; set; }

		[PersistedMember]
		public abstract string Comment { get; set; }

		[PersistedMember]
		public abstract string CreditCardApprovalCode { get; set; }

		[PersistedMember]
		public abstract DateTime DueDate { get; set; }

		[PersistedMember]
		public abstract decimal Freight { get; set; }

		[PersistedMember]
		public abstract DateTime ModifiedDate { get; set; }

		[PersistedMember]
		public abstract bool OnlineOrderFlag { get; set; }

		[PersistedMember]
		public abstract DateTime OrderDate { get; set; }

		[PersistedMember]
		public abstract string PurchaseOrderNumber { get; set; }

		[PersistedMember]
		public abstract byte RevisionNumber { get; set; }

		[PersistedMember]
		public abstract Guid rowguid { get; set; }

		[PersistedMember]
		public abstract string SalesOrderNumber { get; set; } // computed

		[PersistedMember]
		public abstract DateTime? ShipDate { get; set; }

		[PersistedMember]
		public abstract byte Status { get; set; }

		[PersistedMember]
		public abstract decimal SubTotal { get; set; }

		[PersistedMember]
		public abstract decimal TaxAmt { get; set; }

		[PersistedMember]
		public abstract decimal TotalDue { get; set; }

		//[PersistedMember]
		//public abstract int CustomerID { get; set; }

		[PersistedMember]
		public abstract int? SalesPersonID { get; set; }

		[PersistedMember]
		public abstract int? TerritoryID { get; set; }

		[PersistedMember]
		public abstract int BillToAddressID { get; set; }

		[PersistedMember]
		public abstract int ShipToAddressID { get; set; }

		[PersistedMember]
		public abstract int ShipMethodID { get; set; }

		[PersistedMember]
		public abstract int? CreditCardID { get; set; }

		[PersistedMember]
		public abstract int? CurrencyRateID { get; set; }

		[RelatedDataAccessObjects]
		public abstract RelatedDataAccessObjects<SalesOrderDetail> SalesOrderDetails { get; }

		[BackReference]
		[ValueRequired]
		public abstract Customer Customer { get; set; }
	}
}
