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
	/// <summary>Class which represents the entity 'ContactCreditCard', mapped on table 'AdventureWorks.Sales.ContactCreditCard'.</summary>
	[Table(Name="[Sales].[ContactCreditCard]")]
	public partial class ContactCreditCard : INotifyPropertyChanging, INotifyPropertyChanged
	{
		#region Events
		/// <summary>Event which is raised when a property value is changing.</summary>
		public event PropertyChangingEventHandler PropertyChanging;
		/// <summary>Event which is raised when a property value changes.</summary>
		public event PropertyChangedEventHandler PropertyChanged;
		#endregion
		
		#region Class Member Declarations
		private System.Int32	_contactId;
		private System.Int32	_creditCardId;
		private System.DateTime	_modifiedDate;
		private EntityRef <Contact> _contact;
		private EntityRef <CreditCard> _creditCard;
		#endregion
		
		#region Extensibility Method Definitions
		partial void OnLoaded();
		partial void OnValidate(System.Data.Linq.ChangeAction action);
		partial void OnCreated();
		partial void OnContactIdChanging(System.Int32 value);
		partial void OnContactIdChanged();
		partial void OnCreditCardIdChanging(System.Int32 value);
		partial void OnCreditCardIdChanged();
		partial void OnModifiedDateChanging(System.DateTime value);
		partial void OnModifiedDateChanged();
		#endregion
		
		/// <summary>Initializes a new instance of the <see cref="ContactCreditCard"/> class.</summary>
		public ContactCreditCard()
		{
			_contact = default(EntityRef<Contact>);
			_creditCard = default(EntityRef<CreditCard>);
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
		

		#region Class Property Declarations
		/// <summary>Gets or sets the ContactId field. Mapped on target field 'ContactID'. </summary>
		[Column(Name="ContactID", Storage="_contactId", CanBeNull=false, DbType="int NOT NULL", IsPrimaryKey=true)]
		public System.Int32 ContactId
		{
			get	{ return _contactId; }
			set
			{
				if((_contactId != value))
				{
					if(_contact.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					OnContactIdChanging(value);
					SendPropertyChanging("ContactId");
					_contactId = value;
					SendPropertyChanged("ContactId");
					OnContactIdChanged();
				}
			}
		}

		/// <summary>Gets or sets the CreditCardId field. Mapped on target field 'CreditCardID'. </summary>
		[Column(Name="CreditCardID", Storage="_creditCardId", CanBeNull=false, DbType="int NOT NULL", IsPrimaryKey=true)]
		public System.Int32 CreditCardId
		{
			get	{ return _creditCardId; }
			set
			{
				if((_creditCardId != value))
				{
					if(_creditCard.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					OnCreditCardIdChanging(value);
					SendPropertyChanging("CreditCardId");
					_creditCardId = value;
					SendPropertyChanged("CreditCardId");
					OnCreditCardIdChanged();
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

		/// <summary>Represents the navigator which is mapped onto the association 'ContactCreditCard.Contact - Contact.ContactCreditCards (m:1)'</summary>
		[Association(Name="ContactCreditCard_Contact2aace8db3ff64756863e9a1231616848", Storage="_contact", ThisKey="ContactId", IsForeignKey=true)] 
		public Contact Contact
		{
			get { return _contact.Entity; }
			set
			{
				Contact previousValue = _contact.Entity;
				if((previousValue != value) || (_contact.HasLoadedOrAssignedValue == false))
				{
					this.SendPropertyChanging("Contact");
					if(previousValue != null)
					{
						_contact.Entity = null;
						previousValue.ContactCreditCards.Remove(this);
					}
					_contact.Entity = value;
					if(value == null)
					{
						_contactId = default(System.Int32);
					}
					else
					{
						value.ContactCreditCards.Add(this);
						_contactId = value.ContactId;
					}
					this.SendPropertyChanged("Contact");
				}
			}
		}
		
		/// <summary>Represents the navigator which is mapped onto the association 'ContactCreditCard.CreditCard - CreditCard.ContactCreditCards (m:1)'</summary>
		[Association(Name="ContactCreditCard_CreditCard410bed2fa3e341e699bd60957f468c8b", Storage="_creditCard", ThisKey="CreditCardId", IsForeignKey=true)] 
		public CreditCard CreditCard
		{
			get { return _creditCard.Entity; }
			set
			{
				CreditCard previousValue = _creditCard.Entity;
				if((previousValue != value) || (_creditCard.HasLoadedOrAssignedValue == false))
				{
					this.SendPropertyChanging("CreditCard");
					if(previousValue != null)
					{
						_creditCard.Entity = null;
						previousValue.ContactCreditCards.Remove(this);
					}
					_creditCard.Entity = value;
					if(value == null)
					{
						_creditCardId = default(System.Int32);
					}
					else
					{
						value.ContactCreditCards.Add(this);
						_creditCardId = value.CreditCardId;
					}
					this.SendPropertyChanged("CreditCard");
				}
			}
		}
		
		#endregion
	}
}
#pragma warning restore 0649