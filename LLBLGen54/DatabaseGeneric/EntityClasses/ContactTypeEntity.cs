﻿//////////////////////////////////////////////////////////////
// <auto-generated>This code was generated by LLBLGen Pro 5.4.</auto-generated>
//////////////////////////////////////////////////////////////
// Code is generated on: 
// Code is generated using templates: SD.TemplateBindings.SharedTemplates
// Templates vendor: Solutions Design.
// Templates version: 
//////////////////////////////////////////////////////////////
using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Xml.Serialization;
using AdventureWorks.Dal.Adapter.v54.HelperClasses;
using AdventureWorks.Dal.Adapter.v54.FactoryClasses;
using AdventureWorks.Dal.Adapter.v54.RelationClasses;

using SD.LLBLGen.Pro.ORMSupportClasses;

namespace AdventureWorks.Dal.Adapter.v54.EntityClasses
{
	// __LLBLGENPRO_USER_CODE_REGION_START AdditionalNamespaces
	// __LLBLGENPRO_USER_CODE_REGION_END
	/// <summary>Entity class which represents the entity 'ContactType'.<br/><br/></summary>
	[Serializable]
	public partial class ContactTypeEntity : CommonEntityBase
		// __LLBLGENPRO_USER_CODE_REGION_START AdditionalInterfaces
		// __LLBLGENPRO_USER_CODE_REGION_END	
	{
		private EntityCollection<BusinessEntityContactEntity> _businessEntityContacts;

		// __LLBLGENPRO_USER_CODE_REGION_START PrivateMembers
		// __LLBLGENPRO_USER_CODE_REGION_END
		private static ContactTypeEntityStaticMetaData _staticMetaData = new ContactTypeEntityStaticMetaData();
		private static ContactTypeRelations _relationsFactory = new ContactTypeRelations();

		/// <summary>All names of fields mapped onto a relation. Usable for in-memory filtering</summary>
		public static partial class MemberNames
		{
			/// <summary>Member name BusinessEntityContacts</summary>
			public static readonly string BusinessEntityContacts = "BusinessEntityContacts";
		}

		/// <summary>Static meta-data storage for navigator related information</summary>
		protected class ContactTypeEntityStaticMetaData : EntityStaticMetaDataBase
		{
			public ContactTypeEntityStaticMetaData()
			{
				SetEntityCoreInfo("ContactTypeEntity", InheritanceHierarchyType.None, false, (int)AdventureWorks.Dal.Adapter.v54.EntityType.ContactTypeEntity, typeof(ContactTypeEntity), typeof(ContactTypeEntityFactory), false);
				AddNavigatorMetaData<ContactTypeEntity, EntityCollection<BusinessEntityContactEntity>>("BusinessEntityContacts", a => a._businessEntityContacts, (a, b) => a._businessEntityContacts = b, a => a.BusinessEntityContacts, () => new ContactTypeRelations().BusinessEntityContactEntityUsingContactTypeId, typeof(BusinessEntityContactEntity), (int)AdventureWorks.Dal.Adapter.v54.EntityType.BusinessEntityContactEntity);
			}
		}

		/// <summary>Static ctor</summary>
		static ContactTypeEntity()
		{
		}

		/// <summary> CTor</summary>
		public ContactTypeEntity()
		{
			InitClassEmpty(null, null);
		}

		/// <summary> CTor</summary>
		/// <param name="fields">Fields object to set as the fields for this entity.</param>
		public ContactTypeEntity(IEntityFields2 fields)
		{
			InitClassEmpty(null, fields);
		}

		/// <summary> CTor</summary>
		/// <param name="validator">The custom validator object for this ContactTypeEntity</param>
		public ContactTypeEntity(IValidator validator)
		{
			InitClassEmpty(validator, null);
		}

		/// <summary> CTor</summary>
		/// <param name="contactTypeId">PK value for ContactType which data should be fetched into this ContactType object</param>
		public ContactTypeEntity(System.Int32 contactTypeId) : this(contactTypeId, null)
		{
		}

		/// <summary> CTor</summary>
		/// <param name="contactTypeId">PK value for ContactType which data should be fetched into this ContactType object</param>
		/// <param name="validator">The custom validator object for this ContactTypeEntity</param>
		public ContactTypeEntity(System.Int32 contactTypeId, IValidator validator)
		{
			InitClassEmpty(validator, null);
			this.ContactTypeId = contactTypeId;
		}

		/// <summary>Private CTor for deserialization</summary>
		/// <param name="info"></param>
		/// <param name="context"></param>
		protected ContactTypeEntity(SerializationInfo info, StreamingContext context) : base(info, context)
		{
			// __LLBLGENPRO_USER_CODE_REGION_START DeserializationConstructor
			// __LLBLGENPRO_USER_CODE_REGION_END
		}

		/// <summary>Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch the related entities of type 'BusinessEntityContact' to this entity.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoBusinessEntityContacts() { return CreateRelationInfoForNavigator("BusinessEntityContacts"); }
		
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
		/// <param name="validator">The validator object for this ContactTypeEntity</param>
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
		public static ContactTypeRelations Relations { get { return _relationsFactory; } }

		/// <summary>Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'BusinessEntityContact' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathBusinessEntityContacts { get { return _staticMetaData.GetPrefetchPathElement("BusinessEntityContacts", CommonEntityBase.CreateEntityCollection<BusinessEntityContactEntity>()); } }

		/// <summary>The ContactTypeId property of the Entity ContactType<br/><br/></summary>
		/// <remarks>Mapped on  table field: "ContactType"."ContactTypeID".<br/>Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0.<br/>Table field behavior characteristics (is nullable, is PK, is identity): false, true, true</remarks>
		public virtual System.Int32 ContactTypeId
		{
			get { return (System.Int32)GetValue((int)ContactTypeFieldIndex.ContactTypeId, true); }
			set { SetValue((int)ContactTypeFieldIndex.ContactTypeId, value); }		}

		/// <summary>The ModifiedDate property of the Entity ContactType<br/><br/></summary>
		/// <remarks>Mapped on  table field: "ContactType"."ModifiedDate".<br/>Table field type characteristics (type, precision, scale, length): DateTime, 0, 0, 0.<br/>Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.DateTime ModifiedDate
		{
			get { return (System.DateTime)GetValue((int)ContactTypeFieldIndex.ModifiedDate, true); }
			set	{ SetValue((int)ContactTypeFieldIndex.ModifiedDate, value); }
		}

		/// <summary>The Name property of the Entity ContactType<br/><br/></summary>
		/// <remarks>Mapped on  table field: "ContactType"."Name".<br/>Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 50.<br/>Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.String Name
		{
			get { return (System.String)GetValue((int)ContactTypeFieldIndex.Name, true); }
			set	{ SetValue((int)ContactTypeFieldIndex.Name, value); }
		}

		/// <summary>Gets the EntityCollection with the related entities of type 'BusinessEntityContactEntity' which are related to this entity via a relation of type '1:n'. If the EntityCollection hasn't been fetched yet, the collection returned will be empty.<br/><br/></summary>
		[TypeContainedAttribute(typeof(BusinessEntityContactEntity))]
		public virtual EntityCollection<BusinessEntityContactEntity> BusinessEntityContacts { get { return GetOrCreateEntityCollection<BusinessEntityContactEntity, BusinessEntityContactEntityFactory>("ContactType", true, false, ref _businessEntityContacts); } }

		// __LLBLGENPRO_USER_CODE_REGION_START CustomEntityCode
		// __LLBLGENPRO_USER_CODE_REGION_END
	}
}

namespace AdventureWorks.Dal.Adapter.v54
{
	public enum ContactTypeFieldIndex
	{
		///<summary>ContactTypeId. </summary>
		ContactTypeId,
		///<summary>ModifiedDate. </summary>
		ModifiedDate,
		///<summary>Name. </summary>
		Name,
		/// <summary></summary>
		AmountOfFields
	}
}

namespace AdventureWorks.Dal.Adapter.v54.RelationClasses
{
	/// <summary>Implements the relations factory for the entity: ContactType. </summary>
	public partial class ContactTypeRelations: RelationFactory
	{
		/// <summary>Returns a new IEntityRelation object, between ContactTypeEntity and BusinessEntityContactEntity over the 1:n relation they have, using the relation between the fields: ContactType.ContactTypeId - BusinessEntityContact.ContactTypeId</summary>
		public virtual IEntityRelation BusinessEntityContactEntityUsingContactTypeId
		{
			get { return ModelInfoProviderSingleton.GetInstance().CreateRelation(RelationType.OneToMany, "BusinessEntityContacts", true, new[] { ContactTypeFields.ContactTypeId, BusinessEntityContactFields.ContactTypeId }); }
		}

	}
	
	/// <summary>Static class which is used for providing relationship instances which are re-used internally for syncing</summary>
	internal static class StaticContactTypeRelations
	{
		internal static readonly IEntityRelation BusinessEntityContactEntityUsingContactTypeIdStatic = new ContactTypeRelations().BusinessEntityContactEntityUsingContactTypeId;

		/// <summary>CTor</summary>
		static StaticContactTypeRelations() { }
	}
}