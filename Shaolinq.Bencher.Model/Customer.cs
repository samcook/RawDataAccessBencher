using System;

namespace Shaolinq.Bencher.Model
{
	[DataAccessObject]
	public abstract class Customer : DataAccessObject<int>
	{
		[PersistedMember(Name = "CustomerID")]
		public abstract override int Id { get; set; }

		[PersistedMember]
		public abstract int? PersonID { get; set; }

		[PersistedMember]
		public abstract int? StoreID { get; set; }

		[PersistedMember]
		public abstract int? TerritoryID { get; set; }

		[PersistedMember]
		public abstract string AccountNumber { get; set; } // computed

		[PersistedMember]
		public abstract Guid rowguid { get; set; }

		[PersistedMember]
		public abstract DateTime ModifiedDate { get; set; }

		[RelatedDataAccessObjects]
		public abstract RelatedDataAccessObjects<SalesOrderHeader> SalesOrderHeaders { get; }
	}
}