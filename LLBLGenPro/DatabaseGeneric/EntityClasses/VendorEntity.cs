﻿//////////////////////////////////////////////////////////////
// <auto-generated>This code was generated by LLBLGen Pro 5.6.</auto-generated>
//////////////////////////////////////////////////////////////
// Code is generated on: 
// Code is generated using templates: SD.TemplateBindings.SharedTemplates
// Templates vendor: Solutions Design.
//////////////////////////////////////////////////////////////
using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Xml.Serialization;
using AdventureWorks.Dal.Adapter.HelperClasses;
using AdventureWorks.Dal.Adapter.FactoryClasses;
using AdventureWorks.Dal.Adapter.RelationClasses;

using SD.LLBLGen.Pro.ORMSupportClasses;

namespace AdventureWorks.Dal.Adapter.EntityClasses
{
	// __LLBLGENPRO_USER_CODE_REGION_START AdditionalNamespaces
	// __LLBLGENPRO_USER_CODE_REGION_END
	/// <summary>Entity class which represents the entity 'Vendor'.<br/><br/></summary>
	[Serializable]
	public partial class VendorEntity : CommonEntityBase
		// __LLBLGENPRO_USER_CODE_REGION_START AdditionalInterfaces
		// __LLBLGENPRO_USER_CODE_REGION_END	
	{
		private EntityCollection<ProductVendorEntity> _productVendors;
		private EntityCollection<PurchaseOrderHeaderEntity> _purchaseOrderHeaders;
		private BusinessEntityEntity _businessEntity;

		// __LLBLGENPRO_USER_CODE_REGION_START PrivateMembers
		// __LLBLGENPRO_USER_CODE_REGION_END
		private static VendorEntityStaticMetaData _staticMetaData = new VendorEntityStaticMetaData();
		private static VendorRelations _relationsFactory = new VendorRelations();

		/// <summary>All names of fields mapped onto a relation. Usable for in-memory filtering</summary>
		public static partial class MemberNames
		{
			/// <summary>Member name ProductVendors</summary>
			public static readonly string ProductVendors = "ProductVendors";
			/// <summary>Member name PurchaseOrderHeaders</summary>
			public static readonly string PurchaseOrderHeaders = "PurchaseOrderHeaders";
			/// <summary>Member name BusinessEntity</summary>
			public static readonly string BusinessEntity = "BusinessEntity";
		}

		/// <summary>Static meta-data storage for navigator related information</summary>
		protected class VendorEntityStaticMetaData : EntityStaticMetaDataBase
		{
			public VendorEntityStaticMetaData()
			{
				SetEntityCoreInfo("VendorEntity", InheritanceHierarchyType.None, false, (int)AdventureWorks.Dal.Adapter.EntityType.VendorEntity, typeof(VendorEntity), typeof(VendorEntityFactory), false);
				AddNavigatorMetaData<VendorEntity, EntityCollection<ProductVendorEntity>>("ProductVendors", a => a._productVendors, (a, b) => a._productVendors = b, a => a.ProductVendors, () => new VendorRelations().ProductVendorEntityUsingVendorId, typeof(ProductVendorEntity), (int)AdventureWorks.Dal.Adapter.EntityType.ProductVendorEntity);
				AddNavigatorMetaData<VendorEntity, EntityCollection<PurchaseOrderHeaderEntity>>("PurchaseOrderHeaders", a => a._purchaseOrderHeaders, (a, b) => a._purchaseOrderHeaders = b, a => a.PurchaseOrderHeaders, () => new VendorRelations().PurchaseOrderHeaderEntityUsingVendorId, typeof(PurchaseOrderHeaderEntity), (int)AdventureWorks.Dal.Adapter.EntityType.PurchaseOrderHeaderEntity);
				AddNavigatorMetaData<VendorEntity, BusinessEntityEntity>("BusinessEntity", "Vendor", (a, b) => a._businessEntity = b, a => a._businessEntity, (a, b) => a.BusinessEntity = b, AdventureWorks.Dal.Adapter.RelationClasses.StaticVendorRelations.BusinessEntityEntityUsingVendorIdStatic, ()=>new VendorRelations().BusinessEntityEntityUsingVendorId, null, new int[] { (int)VendorFieldIndex.VendorId }, null, false, (int)AdventureWorks.Dal.Adapter.EntityType.BusinessEntityEntity);
			}
		}

		/// <summary>Static ctor</summary>
		static VendorEntity()
		{
		}

		/// <summary> CTor</summary>
		public VendorEntity()
		{
			InitClassEmpty(null, null);
		}

		/// <summary> CTor</summary>
		/// <param name="fields">Fields object to set as the fields for this entity.</param>
		public VendorEntity(IEntityFields2 fields)
		{
			InitClassEmpty(null, fields);
		}

		/// <summary> CTor</summary>
		/// <param name="validator">The custom validator object for this VendorEntity</param>
		public VendorEntity(IValidator validator)
		{
			InitClassEmpty(validator, null);
		}

		/// <summary> CTor</summary>
		/// <param name="vendorId">PK value for Vendor which data should be fetched into this Vendor object</param>
		public VendorEntity(System.Int32 vendorId) : this(vendorId, null)
		{
		}

		/// <summary> CTor</summary>
		/// <param name="vendorId">PK value for Vendor which data should be fetched into this Vendor object</param>
		/// <param name="validator">The custom validator object for this VendorEntity</param>
		public VendorEntity(System.Int32 vendorId, IValidator validator)
		{
			InitClassEmpty(validator, null);
			this.VendorId = vendorId;
		}

		/// <summary>Private CTor for deserialization</summary>
		/// <param name="info"></param>
		/// <param name="context"></param>
		protected VendorEntity(SerializationInfo info, StreamingContext context) : base(info, context)
		{
			// __LLBLGENPRO_USER_CODE_REGION_START DeserializationConstructor
			// __LLBLGENPRO_USER_CODE_REGION_END
		}

		/// <summary>Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch the related entities of type 'ProductVendor' to this entity.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoProductVendors() { return CreateRelationInfoForNavigator("ProductVendors"); }

		/// <summary>Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch the related entities of type 'PurchaseOrderHeader' to this entity.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoPurchaseOrderHeaders() { return CreateRelationInfoForNavigator("PurchaseOrderHeaders"); }

		/// <summary>Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch the related entity of type 'BusinessEntity' to this entity.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoBusinessEntity() { return CreateRelationInfoForNavigator("BusinessEntity"); }
		
		/// <inheritdoc/>
		protected override EntityStaticMetaDataBase GetEntityStaticMetaData() {	return _staticMetaData; }

		/// <summary>Initializes the class members</summary>
		private void InitClassMembers()
		{
			PerformDependencyInjection();
			// __LLBLGENPRO_USER_CODE_REGION_START InitClassMembers
			// __LLBLGENPRO_USER_CODE_REGION_END
			OnInitClassMembersComplete();
		}

		/// <summary>Initializes the class with empty data, as if it is a new Entity.</summary>
		/// <param name="validator">The validator object for this VendorEntity</param>
		/// <param name="fields">Fields of this entity</param>
		private void InitClassEmpty(IValidator validator, IEntityFields2 fields)
		{
			OnInitializing();
			this.Fields = fields ?? CreateFields();
			this.Validator = validator;
			InitClassMembers();
			// __LLBLGENPRO_USER_CODE_REGION_START InitClassEmpty
			// __LLBLGENPRO_USER_CODE_REGION_END

			OnInitialized();
		}

		/// <summary>The relations object holding all relations of this entity with other entity classes.</summary>
		public static VendorRelations Relations { get { return _relationsFactory; } }

		/// <summary>Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'ProductVendor' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathProductVendors { get { return _staticMetaData.GetPrefetchPathElement("ProductVendors", CommonEntityBase.CreateEntityCollection<ProductVendorEntity>()); } }

		/// <summary>Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'PurchaseOrderHeader' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathPurchaseOrderHeaders { get { return _staticMetaData.GetPrefetchPathElement("PurchaseOrderHeaders", CommonEntityBase.CreateEntityCollection<PurchaseOrderHeaderEntity>()); } }

		/// <summary>Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'BusinessEntity' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathBusinessEntity { get { return _staticMetaData.GetPrefetchPathElement("BusinessEntity", CommonEntityBase.CreateEntityCollection<BusinessEntityEntity>()); } }

		/// <summary>The AccountNumber property of the Entity Vendor<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Vendor"."AccountNumber".<br/>Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 15.<br/>Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.String AccountNumber
		{
			get { return (System.String)GetValue((int)VendorFieldIndex.AccountNumber, true); }
			set	{ SetValue((int)VendorFieldIndex.AccountNumber, value); }
		}

		/// <summary>The ActiveFlag property of the Entity Vendor<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Vendor"."ActiveFlag".<br/>Table field type characteristics (type, precision, scale, length): Bit, 0, 0, 0.<br/>Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.Boolean ActiveFlag
		{
			get { return (System.Boolean)GetValue((int)VendorFieldIndex.ActiveFlag, true); }
			set	{ SetValue((int)VendorFieldIndex.ActiveFlag, value); }
		}

		/// <summary>The CreditRating property of the Entity Vendor<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Vendor"."CreditRating".<br/>Table field type characteristics (type, precision, scale, length): TinyInt, 3, 0, 0.<br/>Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.Byte CreditRating
		{
			get { return (System.Byte)GetValue((int)VendorFieldIndex.CreditRating, true); }
			set	{ SetValue((int)VendorFieldIndex.CreditRating, value); }
		}

		/// <summary>The ModifiedDate property of the Entity Vendor<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Vendor"."ModifiedDate".<br/>Table field type characteristics (type, precision, scale, length): DateTime, 0, 0, 0.<br/>Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.DateTime ModifiedDate
		{
			get { return (System.DateTime)GetValue((int)VendorFieldIndex.ModifiedDate, true); }
			set	{ SetValue((int)VendorFieldIndex.ModifiedDate, value); }
		}

		/// <summary>The Name property of the Entity Vendor<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Vendor"."Name".<br/>Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 50.<br/>Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.String Name
		{
			get { return (System.String)GetValue((int)VendorFieldIndex.Name, true); }
			set	{ SetValue((int)VendorFieldIndex.Name, value); }
		}

		/// <summary>The PreferredVendorStatus property of the Entity Vendor<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Vendor"."PreferredVendorStatus".<br/>Table field type characteristics (type, precision, scale, length): Bit, 0, 0, 0.<br/>Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.Boolean PreferredVendorStatus
		{
			get { return (System.Boolean)GetValue((int)VendorFieldIndex.PreferredVendorStatus, true); }
			set	{ SetValue((int)VendorFieldIndex.PreferredVendorStatus, value); }
		}

		/// <summary>The PurchasingWebServiceUrl property of the Entity Vendor<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Vendor"."PurchasingWebServiceURL".<br/>Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 1024.<br/>Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual System.String PurchasingWebServiceUrl
		{
			get { return (System.String)GetValue((int)VendorFieldIndex.PurchasingWebServiceUrl, true); }
			set	{ SetValue((int)VendorFieldIndex.PurchasingWebServiceUrl, value); }
		}

		/// <summary>The VendorId property of the Entity Vendor<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Vendor"."BusinessEntityID".<br/>Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0.<br/>Table field behavior characteristics (is nullable, is PK, is identity): false, true, false</remarks>
		public virtual System.Int32 VendorId
		{
			get { return (System.Int32)GetValue((int)VendorFieldIndex.VendorId, true); }
			set { SetValue((int)VendorFieldIndex.VendorId, value); }		}

		/// <summary>Gets the EntityCollection with the related entities of type 'ProductVendorEntity' which are related to this entity via a relation of type '1:n'. If the EntityCollection hasn't been fetched yet, the collection returned will be empty.<br/><br/></summary>
		[TypeContainedAttribute(typeof(ProductVendorEntity))]
		public virtual EntityCollection<ProductVendorEntity> ProductVendors { get { return GetOrCreateEntityCollection<ProductVendorEntity, ProductVendorEntityFactory>("Vendor", true, false, ref _productVendors); } }

		/// <summary>Gets the EntityCollection with the related entities of type 'PurchaseOrderHeaderEntity' which are related to this entity via a relation of type '1:n'. If the EntityCollection hasn't been fetched yet, the collection returned will be empty.<br/><br/></summary>
		[TypeContainedAttribute(typeof(PurchaseOrderHeaderEntity))]
		public virtual EntityCollection<PurchaseOrderHeaderEntity> PurchaseOrderHeaders { get { return GetOrCreateEntityCollection<PurchaseOrderHeaderEntity, PurchaseOrderHeaderEntityFactory>("Vendor", true, false, ref _purchaseOrderHeaders); } }

		/// <summary>Gets / sets related entity of type 'BusinessEntityEntity' which has to be set using a fetch action earlier. If no related entity is set for this property, null is returned.<br/><br/></summary>
		[Browsable(false)]
		public virtual BusinessEntityEntity BusinessEntity
		{
			get { return _businessEntity; }
			set { SetSingleRelatedEntityNavigator(value, "BusinessEntity"); }
		}

		// __LLBLGENPRO_USER_CODE_REGION_START CustomEntityCode
		// __LLBLGENPRO_USER_CODE_REGION_END

	}
}

namespace AdventureWorks.Dal.Adapter
{
	public enum VendorFieldIndex
	{
		///<summary>AccountNumber. </summary>
		AccountNumber,
		///<summary>ActiveFlag. </summary>
		ActiveFlag,
		///<summary>CreditRating. </summary>
		CreditRating,
		///<summary>ModifiedDate. </summary>
		ModifiedDate,
		///<summary>Name. </summary>
		Name,
		///<summary>PreferredVendorStatus. </summary>
		PreferredVendorStatus,
		///<summary>PurchasingWebServiceUrl. </summary>
		PurchasingWebServiceUrl,
		///<summary>VendorId. </summary>
		VendorId,
		/// <summary></summary>
		AmountOfFields
	}
}

namespace AdventureWorks.Dal.Adapter.RelationClasses
{
	/// <summary>Implements the relations factory for the entity: Vendor. </summary>
	public partial class VendorRelations: RelationFactory
	{
		/// <summary>Returns a new IEntityRelation object, between VendorEntity and ProductVendorEntity over the 1:n relation they have, using the relation between the fields: Vendor.VendorId - ProductVendor.VendorId</summary>
		public virtual IEntityRelation ProductVendorEntityUsingVendorId
		{
			get { return ModelInfoProviderSingleton.GetInstance().CreateRelation(RelationType.OneToMany, "ProductVendors", true, new[] { VendorFields.VendorId, ProductVendorFields.VendorId }); }
		}

		/// <summary>Returns a new IEntityRelation object, between VendorEntity and PurchaseOrderHeaderEntity over the 1:n relation they have, using the relation between the fields: Vendor.VendorId - PurchaseOrderHeader.VendorId</summary>
		public virtual IEntityRelation PurchaseOrderHeaderEntityUsingVendorId
		{
			get { return ModelInfoProviderSingleton.GetInstance().CreateRelation(RelationType.OneToMany, "PurchaseOrderHeaders", true, new[] { VendorFields.VendorId, PurchaseOrderHeaderFields.VendorId }); }
		}

		/// <summary>Returns a new IEntityRelation object, between VendorEntity and BusinessEntityEntity over the 1:1 relation they have, using the relation between the fields: Vendor.VendorId - BusinessEntity.BusinessEntityId</summary>
		public virtual IEntityRelation BusinessEntityEntityUsingVendorId
		{
			get	{ return ModelInfoProviderSingleton.GetInstance().CreateRelation(RelationType.OneToOne, "BusinessEntity", false, new[] { BusinessEntityFields.BusinessEntityId, VendorFields.VendorId }); }
		}

	}
	
	/// <summary>Static class which is used for providing relationship instances which are re-used internally for syncing</summary>
	internal static class StaticVendorRelations
	{
		internal static readonly IEntityRelation ProductVendorEntityUsingVendorIdStatic = new VendorRelations().ProductVendorEntityUsingVendorId;
		internal static readonly IEntityRelation PurchaseOrderHeaderEntityUsingVendorIdStatic = new VendorRelations().PurchaseOrderHeaderEntityUsingVendorId;
		internal static readonly IEntityRelation BusinessEntityEntityUsingVendorIdStatic = new VendorRelations().BusinessEntityEntityUsingVendorId;

		/// <summary>CTor</summary>
		static StaticVendorRelations() { }
	}
}