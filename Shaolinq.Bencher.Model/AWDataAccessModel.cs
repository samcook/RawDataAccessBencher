namespace Shaolinq.Bencher.Model
{
	[DataAccessModel]
	public abstract class AWDataAccessModel : DataAccessModel
	{
		[DataAccessObjects]
		public abstract DataAccessObjects<SalesOrderHeader> SalesOrderHeaders { get; }
		
		[DataAccessObjects]
		public abstract DataAccessObjects<SalesOrderDetail> SalesOrderDetails { get; }

		[DataAccessObjects]
		public abstract DataAccessObjects<Customer> Customers { get; }
	}
}