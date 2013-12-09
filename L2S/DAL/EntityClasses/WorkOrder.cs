﻿#pragma warning disable 0649
//------------------------------------------------------------------------------
// <auto-generated>This code was generated by LLBLGen Pro v4.1.</auto-generated>
//------------------------------------------------------------------------------
using System;
using System.Data.Linq;
using System.Data.Linq.Mapping;
using System.ComponentModel;

namespace L2S.Bencher.EntityClasses
{
	/// <summary>Class which represents the entity 'WorkOrder', mapped on table 'AdventureWorks.Production.WorkOrder'.</summary>
	[Table(Name="[Production].[WorkOrder]")]
	public partial class WorkOrder : INotifyPropertyChanging, INotifyPropertyChanged
	{
		#region Events
		/// <summary>Event which is raised when a property value is changing.</summary>
		public event PropertyChangingEventHandler PropertyChanging;
		/// <summary>Event which is raised when a property value changes.</summary>
		public event PropertyChangedEventHandler PropertyChanged;
		#endregion
		
		#region Class Member Declarations
		private System.DateTime	_dueDate;
		private Nullable<System.DateTime>	_endDate;
		private System.DateTime	_modifiedDate;
		private System.Int32	_orderQty;
		private System.Int32	_productId;
		private System.Int16	_scrappedQty;
		private Nullable<System.Int16>	_scrapReasonId;
		private System.DateTime	_startDate;
		private System.Int32	_stockedQty;
		private System.Int32	_workOrderId;
		private EntityRef <Product> _product;
		private EntityRef <ScrapReason> _scrapReason;
		private EntitySet <WorkOrderRouting> _workOrderRoutings;
		#endregion
		
		#region Extensibility Method Definitions
		partial void OnLoaded();
		partial void OnValidate(System.Data.Linq.ChangeAction action);
		partial void OnCreated();
		partial void OnDueDateChanging(System.DateTime value);
		partial void OnDueDateChanged();
		partial void OnEndDateChanging(Nullable<System.DateTime> value);
		partial void OnEndDateChanged();
		partial void OnModifiedDateChanging(System.DateTime value);
		partial void OnModifiedDateChanged();
		partial void OnOrderQtyChanging(System.Int32 value);
		partial void OnOrderQtyChanged();
		partial void OnProductIdChanging(System.Int32 value);
		partial void OnProductIdChanged();
		partial void OnScrappedQtyChanging(System.Int16 value);
		partial void OnScrappedQtyChanged();
		partial void OnScrapReasonIdChanging(Nullable<System.Int16> value);
		partial void OnScrapReasonIdChanged();
		partial void OnStartDateChanging(System.DateTime value);
		partial void OnStartDateChanged();
		partial void OnStockedQtyChanging(System.Int32 value);
		partial void OnStockedQtyChanged();
		partial void OnWorkOrderIdChanging(System.Int32 value);
		partial void OnWorkOrderIdChanged();
		#endregion
		
		/// <summary>Initializes a new instance of the <see cref="WorkOrder"/> class.</summary>
		public WorkOrder()
		{
			_product = default(EntityRef<Product>);
			_scrapReason = default(EntityRef<ScrapReason>);
			_workOrderRoutings = new EntitySet<WorkOrderRouting>(new Action<WorkOrderRouting>(this.Attach_WorkOrderRoutings), new Action<WorkOrderRouting>(this.Detach_WorkOrderRoutings) );
			OnCreated();
		}

		/// <summary>Raises the PropertyChanging event</summary>
		/// <param name="propertyName">name of the property which is changing</param>
		protected virtual void SendPropertyChanging(string propertyName)
		{
			if((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, new PropertyChangingEventArgs(propertyName));
			}
		}
		
		/// <summary>Raises the PropertyChanged event for the property specified</summary>
		/// <param name="propertyName">name of the property which was changed</param>
		protected virtual void SendPropertyChanged(string propertyName)
		{
			if((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
		
		/// <summary>Attaches this instance to the entity specified as an associated entity</summary>
		/// <param name="entity">The related entity to attach to</param>
		private void Attach_WorkOrderRoutings(WorkOrderRouting entity)
		{
			this.SendPropertyChanging("WorkOrderRoutings");
			entity.WorkOrder = this;
		}
		
		/// <summary>Detaches this instance from the entity specified so it's no longer an associated entity</summary>
		/// <param name="entity">The related entity to detach from</param>
		private void Detach_WorkOrderRoutings(WorkOrderRouting entity)
		{
			this.SendPropertyChanging("WorkOrderRoutings");
			entity.WorkOrder = null;
		}


		#region Class Property Declarations
		/// <summary>Gets or sets the DueDate field. Mapped on target field 'DueDate'. </summary>
		[Column(Name="DueDate", Storage="_dueDate", CanBeNull=false, DbType="datetime NOT NULL")]
		public System.DateTime DueDate
		{
			get	{ return _dueDate; }
			set
			{
				if((_dueDate != value))
				{
					OnDueDateChanging(value);
					SendPropertyChanging("DueDate");
					_dueDate = value;
					SendPropertyChanged("DueDate");
					OnDueDateChanged();
				}
			}
		}

		/// <summary>Gets or sets the EndDate field. Mapped on target field 'EndDate'. </summary>
		[Column(Name="EndDate", Storage="_endDate", DbType="datetime NULL")]
		public Nullable<System.DateTime> EndDate
		{
			get	{ return _endDate; }
			set
			{
				if((_endDate != value))
				{
					OnEndDateChanging(value);
					SendPropertyChanging("EndDate");
					_endDate = value;
					SendPropertyChanged("EndDate");
					OnEndDateChanged();
				}
			}
		}

		/// <summary>Gets or sets the ModifiedDate field. Mapped on target field 'ModifiedDate'. </summary>
		[Column(Name="ModifiedDate", Storage="_modifiedDate", CanBeNull=false, DbType="datetime NOT NULL")]
		public System.DateTime ModifiedDate
		{
			get	{ return _modifiedDate; }
			set
			{
				if((_modifiedDate != value))
				{
					OnModifiedDateChanging(value);
					SendPropertyChanging("ModifiedDate");
					_modifiedDate = value;
					SendPropertyChanged("ModifiedDate");
					OnModifiedDateChanged();
				}
			}
		}

		/// <summary>Gets or sets the OrderQty field. Mapped on target field 'OrderQty'. </summary>
		[Column(Name="OrderQty", Storage="_orderQty", CanBeNull=false, DbType="int NOT NULL")]
		public System.Int32 OrderQty
		{
			get	{ return _orderQty; }
			set
			{
				if((_orderQty != value))
				{
					OnOrderQtyChanging(value);
					SendPropertyChanging("OrderQty");
					_orderQty = value;
					SendPropertyChanged("OrderQty");
					OnOrderQtyChanged();
				}
			}
		}

		/// <summary>Gets or sets the ProductId field. Mapped on target field 'ProductID'. </summary>
		[Column(Name="ProductID", Storage="_productId", CanBeNull=false, DbType="int NOT NULL")]
		public System.Int32 ProductId
		{
			get	{ return _productId; }
			set
			{
				if((_productId != value))
				{
					if(_product.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					OnProductIdChanging(value);
					SendPropertyChanging("ProductId");
					_productId = value;
					SendPropertyChanged("ProductId");
					OnProductIdChanged();
				}
			}
		}

		/// <summary>Gets or sets the ScrappedQty field. Mapped on target field 'ScrappedQty'. </summary>
		[Column(Name="ScrappedQty", Storage="_scrappedQty", CanBeNull=false, DbType="smallint NOT NULL")]
		public System.Int16 ScrappedQty
		{
			get	{ return _scrappedQty; }
			set
			{
				if((_scrappedQty != value))
				{
					OnScrappedQtyChanging(value);
					SendPropertyChanging("ScrappedQty");
					_scrappedQty = value;
					SendPropertyChanged("ScrappedQty");
					OnScrappedQtyChanged();
				}
			}
		}

		/// <summary>Gets or sets the ScrapReasonId field. Mapped on target field 'ScrapReasonID'. </summary>
		[Column(Name="ScrapReasonID", Storage="_scrapReasonId", DbType="smallint NULL")]
		public Nullable<System.Int16> ScrapReasonId
		{
			get	{ return _scrapReasonId; }
			set
			{
				if((_scrapReasonId != value))
				{
					if(_scrapReason.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					OnScrapReasonIdChanging(value);
					SendPropertyChanging("ScrapReasonId");
					_scrapReasonId = value;
					SendPropertyChanged("ScrapReasonId");
					OnScrapReasonIdChanged();
				}
			}
		}

		/// <summary>Gets or sets the StartDate field. Mapped on target field 'StartDate'. </summary>
		[Column(Name="StartDate", Storage="_startDate", CanBeNull=false, DbType="datetime NOT NULL")]
		public System.DateTime StartDate
		{
			get	{ return _startDate; }
			set
			{
				if((_startDate != value))
				{
					OnStartDateChanging(value);
					SendPropertyChanging("StartDate");
					_startDate = value;
					SendPropertyChanged("StartDate");
					OnStartDateChanged();
				}
			}
		}

		/// <summary>Gets or sets the StockedQty field. Mapped on target field 'StockedQty'. </summary>
		[Column(Name="StockedQty", Storage="_stockedQty", AutoSync=AutoSync.OnInsert, CanBeNull=false, DbType="int NOT NULL", IsDbGenerated=true, UpdateCheck=UpdateCheck.Never)]
		public System.Int32 StockedQty
		{
			get	{ return _stockedQty; }
		}

		/// <summary>Gets or sets the WorkOrderId field. Mapped on target field 'WorkOrderID'. </summary>
		[Column(Name="WorkOrderID", Storage="_workOrderId", AutoSync=AutoSync.OnInsert, CanBeNull=false, DbType="int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true, UpdateCheck=UpdateCheck.Never)]
		public System.Int32 WorkOrderId
		{
			get	{ return _workOrderId; }
			set
			{
				if((_workOrderId != value))
				{
					OnWorkOrderIdChanging(value);
					SendPropertyChanging("WorkOrderId");
					_workOrderId = value;
					SendPropertyChanged("WorkOrderId");
					OnWorkOrderIdChanged();
				}
			}
		}

		/// <summary>Represents the navigator which is mapped onto the association 'WorkOrder.Product - Product.WorkOrders (m:1)'</summary>
		[Association(Name="WorkOrder_Product8099b6d23f3840be89b6f1ca77c8e946", Storage="_product", ThisKey="ProductId", IsForeignKey=true)] 
		public Product Product
		{
			get { return _product.Entity; }
			set
			{
				Product previousValue = _product.Entity;
				if((previousValue != value) || (_product.HasLoadedOrAssignedValue == false))
				{
					this.SendPropertyChanging("Product");
					if(previousValue != null)
					{
						_product.Entity = null;
						previousValue.WorkOrders.Remove(this);
					}
					_product.Entity = value;
					if(value == null)
					{
						_productId = default(System.Int32);
					}
					else
					{
						value.WorkOrders.Add(this);
						_productId = value.ProductId;
					}
					this.SendPropertyChanged("Product");
				}
			}
		}
		
		/// <summary>Represents the navigator which is mapped onto the association 'WorkOrder.ScrapReason - ScrapReason.WorkOrders (m:1)'</summary>
		[Association(Name="WorkOrder_ScrapReason73b923f5d2a247319892873d2d37b46f", Storage="_scrapReason", ThisKey="ScrapReasonId", IsForeignKey=true)] 
		public ScrapReason ScrapReason
		{
			get { return _scrapReason.Entity; }
			set
			{
				ScrapReason previousValue = _scrapReason.Entity;
				if((previousValue != value) || (_scrapReason.HasLoadedOrAssignedValue == false))
				{
					this.SendPropertyChanging("ScrapReason");
					if(previousValue != null)
					{
						_scrapReason.Entity = null;
						previousValue.WorkOrders.Remove(this);
					}
					_scrapReason.Entity = value;
					if(value == null)
					{
						_scrapReasonId = default(Nullable<System.Int16>);
					}
					else
					{
						value.WorkOrders.Add(this);
						_scrapReasonId = value.ScrapReasonId;
					}
					this.SendPropertyChanged("ScrapReason");
				}
			}
		}
		
		/// <summary>Represents the navigator which is mapped onto the association 'WorkOrderRouting.WorkOrder - WorkOrder.WorkOrderRoutings (m:1)'</summary>
		[Association(Name="WorkOrderRouting_WorkOrder720634570f7646ccab3138f931ce2df0", Storage="_workOrderRoutings", OtherKey="WorkOrderId")]
		public EntitySet<WorkOrderRouting> WorkOrderRoutings
		{
			get { return this._workOrderRoutings; }
			set { this._workOrderRoutings.Assign(value); }
		}
		
		#endregion
	}
}
#pragma warning restore 0649