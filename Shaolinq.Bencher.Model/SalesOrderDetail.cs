using System;

namespace Shaolinq.Bencher.Model
{
	[DataAccessObject]
	public abstract class SalesOrderDetail : DataAccessObject<int>
	{
		[PersistedMember(Name = "SalesOrderDetailID")]
		public abstract override int Id { get; set; }

		[PrimaryKey]
		[BackReference]
		public abstract SalesOrderHeader SalesOrder { get; set; }

		[PersistedMember]
		public abstract string CarrierTrackingNumber { get; set; }

		[PersistedMember]
		public abstract short OrderQty { get; set; }

		[PersistedMember]
		public abstract int ProductID { get; set; }

		[PersistedMember]
		public abstract int SpecialOfferID { get; set; }

		[PersistedMember]
		public abstract decimal UnitPrice { get; set; }

		[PersistedMember]
		public abstract decimal UnitPriceDiscount { get; set; }

		[PersistedMember]
		public abstract decimal LineTotal { get; set; } // computed

		[PersistedMember]
		public abstract Guid rowguid { get; set; }

		[PersistedMember]
		public abstract DateTime ModifiedDate { get; set; }
	}
}
