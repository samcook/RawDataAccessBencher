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
	/// <summary>Entity class which represents the entity 'PersonPhone'.<br/><br/></summary>
	[Serializable]
	public partial class PersonPhoneEntity : CommonEntityBase
		// __LLBLGENPRO_USER_CODE_REGION_START AdditionalInterfaces
		// __LLBLGENPRO_USER_CODE_REGION_END	
	{
		private PersonEntity _person;
		private PhoneNumberTypeEntity _phoneNumberType;

		// __LLBLGENPRO_USER_CODE_REGION_START PrivateMembers
		// __LLBLGENPRO_USER_CODE_REGION_END
		private static PersonPhoneEntityStaticMetaData _staticMetaData = new PersonPhoneEntityStaticMetaData();
		private static PersonPhoneRelations _relationsFactory = new PersonPhoneRelations();

		/// <summary>All names of fields mapped onto a relation. Usable for in-memory filtering</summary>
		public static partial class MemberNames
		{
			/// <summary>Member name Person</summary>
			public static readonly string Person = "Person";
			/// <summary>Member name PhoneNumberType</summary>
			public static readonly string PhoneNumberType = "PhoneNumberType";
		}

		/// <summary>Static meta-data storage for navigator related information</summary>
		protected class PersonPhoneEntityStaticMetaData : EntityStaticMetaDataBase
		{
			public PersonPhoneEntityStaticMetaData()
			{
				SetEntityCoreInfo("PersonPhoneEntity", InheritanceHierarchyType.None, false, (int)AdventureWorks.Dal.Adapter.EntityType.PersonPhoneEntity, typeof(PersonPhoneEntity), typeof(PersonPhoneEntityFactory), false);
				AddNavigatorMetaData<PersonPhoneEntity, PersonEntity>("Person", "PersonPhones", (a, b) => a._person = b, a => a._person, (a, b) => a.Person = b, AdventureWorks.Dal.Adapter.RelationClasses.StaticPersonPhoneRelations.PersonEntityUsingBusinessEntityIdStatic, ()=>new PersonPhoneRelations().PersonEntityUsingBusinessEntityId, null, new int[] { (int)PersonPhoneFieldIndex.BusinessEntityId }, null, true, (int)AdventureWorks.Dal.Adapter.EntityType.PersonEntity);
				AddNavigatorMetaData<PersonPhoneEntity, PhoneNumberTypeEntity>("PhoneNumberType", "PersonPhones", (a, b) => a._phoneNumberType = b, a => a._phoneNumberType, (a, b) => a.PhoneNumberType = b, AdventureWorks.Dal.Adapter.RelationClasses.StaticPersonPhoneRelations.PhoneNumberTypeEntityUsingPhoneNumberTypeIdStatic, ()=>new PersonPhoneRelations().PhoneNumberTypeEntityUsingPhoneNumberTypeId, null, new int[] { (int)PersonPhoneFieldIndex.PhoneNumberTypeId }, null, true, (int)AdventureWorks.Dal.Adapter.EntityType.PhoneNumberTypeEntity);
			}
		}

		/// <summary>Static ctor</summary>
		static PersonPhoneEntity()
		{
		}

		/// <summary> CTor</summary>
		public PersonPhoneEntity()
		{
			InitClassEmpty(null, null);
		}

		/// <summary> CTor</summary>
		/// <param name="fields">Fields object to set as the fields for this entity.</param>
		public PersonPhoneEntity(IEntityFields2 fields)
		{
			InitClassEmpty(null, fields);
		}

		/// <summary> CTor</summary>
		/// <param name="validator">The custom validator object for this PersonPhoneEntity</param>
		public PersonPhoneEntity(IValidator validator)
		{
			InitClassEmpty(validator, null);
		}

		/// <summary> CTor</summary>
		/// <param name="businessEntityId">PK value for PersonPhone which data should be fetched into this PersonPhone object</param>
		/// <param name="phoneNumber">PK value for PersonPhone which data should be fetched into this PersonPhone object</param>
		/// <param name="phoneNumberTypeId">PK value for PersonPhone which data should be fetched into this PersonPhone object</param>
		public PersonPhoneEntity(System.Int32 businessEntityId, System.String phoneNumber, System.Int32 phoneNumberTypeId) : this(businessEntityId, phoneNumber, phoneNumberTypeId, null)
		{
		}

		/// <summary> CTor</summary>
		/// <param name="businessEntityId">PK value for PersonPhone which data should be fetched into this PersonPhone object</param>
		/// <param name="phoneNumber">PK value for PersonPhone which data should be fetched into this PersonPhone object</param>
		/// <param name="phoneNumberTypeId">PK value for PersonPhone which data should be fetched into this PersonPhone object</param>
		/// <param name="validator">The custom validator object for this PersonPhoneEntity</param>
		public PersonPhoneEntity(System.Int32 businessEntityId, System.String phoneNumber, System.Int32 phoneNumberTypeId, IValidator validator)
		{
			InitClassEmpty(validator, null);
			this.BusinessEntityId = businessEntityId;
			this.PhoneNumber = phoneNumber;
			this.PhoneNumberTypeId = phoneNumberTypeId;
		}

		/// <summary>Private CTor for deserialization</summary>
		/// <param name="info"></param>
		/// <param name="context"></param>
		protected PersonPhoneEntity(SerializationInfo info, StreamingContext context) : base(info, context)
		{
			// __LLBLGENPRO_USER_CODE_REGION_START DeserializationConstructor
			// __LLBLGENPRO_USER_CODE_REGION_END
		}

		/// <summary>Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch the related entity of type 'Person' to this entity.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoPerson() { return CreateRelationInfoForNavigator("Person"); }

		/// <summary>Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch the related entity of type 'PhoneNumberType' to this entity.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoPhoneNumberType() { return CreateRelationInfoForNavigator("PhoneNumberType"); }
		
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
		/// <param name="validator">The validator object for this PersonPhoneEntity</param>
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
		public static PersonPhoneRelations Relations { get { return _relationsFactory; } }

		/// <summary>Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'Person' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathPerson { get { return _staticMetaData.GetPrefetchPathElement("Person", CommonEntityBase.CreateEntityCollection<PersonEntity>()); } }

		/// <summary>Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'PhoneNumberType' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathPhoneNumberType { get { return _staticMetaData.GetPrefetchPathElement("PhoneNumberType", CommonEntityBase.CreateEntityCollection<PhoneNumberTypeEntity>()); } }

		/// <summary>The BusinessEntityId property of the Entity PersonPhone<br/><br/></summary>
		/// <remarks>Mapped on  table field: "PersonPhone"."BusinessEntityID".<br/>Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0.<br/>Table field behavior characteristics (is nullable, is PK, is identity): false, true, false</remarks>
		public virtual System.Int32 BusinessEntityId
		{
			get { return (System.Int32)GetValue((int)PersonPhoneFieldIndex.BusinessEntityId, true); }
			set	{ SetValue((int)PersonPhoneFieldIndex.BusinessEntityId, value); }
		}

		/// <summary>The ModifiedDate property of the Entity PersonPhone<br/><br/></summary>
		/// <remarks>Mapped on  table field: "PersonPhone"."ModifiedDate".<br/>Table field type characteristics (type, precision, scale, length): DateTime, 0, 0, 0.<br/>Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.DateTime ModifiedDate
		{
			get { return (System.DateTime)GetValue((int)PersonPhoneFieldIndex.ModifiedDate, true); }
			set	{ SetValue((int)PersonPhoneFieldIndex.ModifiedDate, value); }
		}

		/// <summary>The PhoneNumber property of the Entity PersonPhone<br/><br/></summary>
		/// <remarks>Mapped on  table field: "PersonPhone"."PhoneNumber".<br/>Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 25.<br/>Table field behavior characteristics (is nullable, is PK, is identity): false, true, false</remarks>
		public virtual System.String PhoneNumber
		{
			get { return (System.String)GetValue((int)PersonPhoneFieldIndex.PhoneNumber, true); }
			set	{ SetValue((int)PersonPhoneFieldIndex.PhoneNumber, value); }
		}

		/// <summary>The PhoneNumberTypeId property of the Entity PersonPhone<br/><br/></summary>
		/// <remarks>Mapped on  table field: "PersonPhone"."PhoneNumberTypeID".<br/>Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0.<br/>Table field behavior characteristics (is nullable, is PK, is identity): false, true, false</remarks>
		public virtual System.Int32 PhoneNumberTypeId
		{
			get { return (System.Int32)GetValue((int)PersonPhoneFieldIndex.PhoneNumberTypeId, true); }
			set	{ SetValue((int)PersonPhoneFieldIndex.PhoneNumberTypeId, value); }
		}

		/// <summary>Gets / sets related entity of type 'PersonEntity' which has to be set using a fetch action earlier. If no related entity is set for this property, null is returned..<br/><br/></summary>
		[Browsable(false)]
		public virtual PersonEntity Person
		{
			get { return _person; }
			set { SetSingleRelatedEntityNavigator(value, "Person"); }
		}

		/// <summary>Gets / sets related entity of type 'PhoneNumberTypeEntity' which has to be set using a fetch action earlier. If no related entity is set for this property, null is returned..<br/><br/></summary>
		[Browsable(false)]
		public virtual PhoneNumberTypeEntity PhoneNumberType
		{
			get { return _phoneNumberType; }
			set { SetSingleRelatedEntityNavigator(value, "PhoneNumberType"); }
		}

		// __LLBLGENPRO_USER_CODE_REGION_START CustomEntityCode
		// __LLBLGENPRO_USER_CODE_REGION_END

	}
}

namespace AdventureWorks.Dal.Adapter
{
	public enum PersonPhoneFieldIndex
	{
		///<summary>BusinessEntityId. </summary>
		BusinessEntityId,
		///<summary>ModifiedDate. </summary>
		ModifiedDate,
		///<summary>PhoneNumber. </summary>
		PhoneNumber,
		///<summary>PhoneNumberTypeId. </summary>
		PhoneNumberTypeId,
		/// <summary></summary>
		AmountOfFields
	}
}

namespace AdventureWorks.Dal.Adapter.RelationClasses
{
	/// <summary>Implements the relations factory for the entity: PersonPhone. </summary>
	public partial class PersonPhoneRelations: RelationFactory
	{

		/// <summary>Returns a new IEntityRelation object, between PersonPhoneEntity and PersonEntity over the m:1 relation they have, using the relation between the fields: PersonPhone.BusinessEntityId - Person.BusinessEntityId</summary>
		public virtual IEntityRelation PersonEntityUsingBusinessEntityId
		{
			get	{ return ModelInfoProviderSingleton.GetInstance().CreateRelation(RelationType.ManyToOne, "Person", false, new[] { PersonFields.BusinessEntityId, PersonPhoneFields.BusinessEntityId }); }
		}

		/// <summary>Returns a new IEntityRelation object, between PersonPhoneEntity and PhoneNumberTypeEntity over the m:1 relation they have, using the relation between the fields: PersonPhone.PhoneNumberTypeId - PhoneNumberType.PhoneNumberTypeId</summary>
		public virtual IEntityRelation PhoneNumberTypeEntityUsingPhoneNumberTypeId
		{
			get	{ return ModelInfoProviderSingleton.GetInstance().CreateRelation(RelationType.ManyToOne, "PhoneNumberType", false, new[] { PhoneNumberTypeFields.PhoneNumberTypeId, PersonPhoneFields.PhoneNumberTypeId }); }
		}

	}
	
	/// <summary>Static class which is used for providing relationship instances which are re-used internally for syncing</summary>
	internal static class StaticPersonPhoneRelations
	{
		internal static readonly IEntityRelation PersonEntityUsingBusinessEntityIdStatic = new PersonPhoneRelations().PersonEntityUsingBusinessEntityId;
		internal static readonly IEntityRelation PhoneNumberTypeEntityUsingPhoneNumberTypeIdStatic = new PersonPhoneRelations().PhoneNumberTypeEntityUsingPhoneNumberTypeId;

		/// <summary>CTor</summary>
		static StaticPersonPhoneRelations() { }
	}
}