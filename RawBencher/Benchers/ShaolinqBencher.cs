using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Shaolinq;
using Shaolinq.Bencher.Model;

namespace RawBencher.Benchers
{
	/// <summary>
	/// Specific bencher for Shaolinq, doing normal fetch
	/// </summary>
	public class ShaolinqBencher : FetchOnlyBencherBase<Shaolinq.Bencher.Model.SalesOrderHeader>
	{
		private readonly DataAccessModelConfiguration config;
		private readonly AWDataAccessModel dataAccessModel;

		/// <summary>
		/// Initializes a new instance of the <see cref="ShaolinqBencher"/> class.
		/// </summary>
		public ShaolinqBencher(string connectionString)
			: base(
				e => e.Id,
				usesChangeTracking: true,
				usesCaching: false,
				supportsEagerLoading:true,
				supportsAsync:true)
		{
			this.config = Shaolinq.SqlServer.SqlServerConfiguration.Create(connectionString, nativeGuids: true);
			this.config.SqlDatabaseContextInfos[0].SchemaName = "Sales";
			this.dataAccessModel = DataAccessModel.BuildDataAccessModel<AWDataAccessModel>(config);
		}

		/// <summary>
		/// Fetches the individual element
		/// </summary>
		/// <param name="key">The key of the element to fetch.</param>
		/// <returns>The fetched element, or null if not found</returns>
		public override Shaolinq.Bencher.Model.SalesOrderHeader FetchIndividual(int key)
		{
			using (var scope = new DataAccessScope())
			{
				return this.dataAccessModel.SalesOrderHeaders.GetByPrimaryKeyOrDefault(key);
			}
		}


		/// <summary>
		/// Fetches the complete set of elements and returns this set as an IEnumerable.
		/// </summary>
		/// <returns>the set fetched</returns>
		public override IEnumerable<Shaolinq.Bencher.Model.SalesOrderHeader> FetchSet()
		{
			using (var scope = new DataAccessScope())
			{
				return this.dataAccessModel.SalesOrderHeaders.ToList();
			}
		}
		

		/// <summary>
		/// Fetches the complete graph using eager loading and returns this as an IEnumerable.
		/// </summary>
		/// <returns>the graph fetched</returns>
		public override IEnumerable<Shaolinq.Bencher.Model.SalesOrderHeader> FetchGraph()
		{
			using (var scope = new DataAccessScope())
			{
				return this.dataAccessModel.SalesOrderHeaders
					.Include(x => x.Customer)
					.Include(x => x.SalesOrderDetails)
					.Where(soh => soh.Id > 50000 && soh.Id <= 51000)
					.ToList();
			}
		}


		public override async Task<IEnumerable<Shaolinq.Bencher.Model.SalesOrderHeader>> FetchGraphAsync()
		{
			using (var scope = new DataAccessScope())
			{
				return await this.dataAccessModel.SalesOrderHeaders
					.Include(x => x.Customer)
					.Include(x => x.SalesOrderDetails)
					.Where(soh => soh.Id > 50000 && soh.Id <= 51000)
					.ToListAsync();
			}
		}


		/// <summary>
		/// Verifies the graph element's children. The parent should contain 2 sets of related elements: SalesOrderDetail and Customer. Both have to be counted and
		/// the count has to stored in the resultContainer, under the particular type. Implementers have to check whether the related elements are actually materialized objects.
		/// </summary>
		/// <param name="parent">The parent.</param>
		/// <param name="resultContainer">The result container.</param>
		public override void VerifyGraphElementChildren(Shaolinq.Bencher.Model.SalesOrderHeader parent, BenchResult resultContainer)
		{
			int amount = 0;
			foreach(var sod in parent.SalesOrderDetails.Items())
			{
				if(sod.Id > 0)
				{
					amount++;
				}
				else
				{
					return;
				}
			}
			resultContainer.IncNumberOfRowsForType(typeof(Shaolinq.Bencher.Model.SalesOrderDetail), amount);
			if(parent.Customer == null || parent.Customer.Id <= 0)
			{
				return;
			}
			resultContainer.IncNumberOfRowsForType(typeof(Shaolinq.Bencher.Model.Customer), 1);
		}


		/// <summary>
		/// Creates the name of the framework this bencher is for. Use the overload which accepts a format string and a type to create a name based on a
		/// specific version
		/// </summary>
		/// <returns>the framework name.</returns>
		protected override string CreateFrameworkNameImpl()
		{
			return CreateFrameworkName("Shaolinq v{0} (v{1})", typeof(DataAccessObject));
		}
	}
}
