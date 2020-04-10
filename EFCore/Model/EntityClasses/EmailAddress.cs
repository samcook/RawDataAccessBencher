﻿//------------------------------------------------------------------------------
// <auto-generated>This code was generated by LLBLGen Pro v5.6.</auto-generated>
//------------------------------------------------------------------------------
using System;
using System.Collections.Generic;

namespace EFCore.Bencher.EntityClasses
{
	/// <summary>Class which represents the entity 'EmailAddress'.</summary>
	public partial class EmailAddress : CommonEntityBase
	{
		/// <summary>Method called from the constructor</summary>
		partial void OnCreated();

		/// <summary>Initializes a new instance of the <see cref="EmailAddress"/> class.</summary>
		public EmailAddress() : base()
		{
			OnCreated();
		}

		/// <summary>Gets or sets the BusinessEntityId field. </summary>
		public System.Int32 BusinessEntityId { get; set; }
		/// <summary>Gets or sets the EmailAddressId field. </summary>
		public System.Int32 EmailAddressId { get; set; }
		/// <summary>Gets or sets the EmailAddressValue field. </summary>
		public System.String EmailAddressValue { get; set; }
		/// <summary>Gets or sets the ModifiedDate field. </summary>
		public System.DateTime ModifiedDate { get; set; }
		/// <summary>Gets or sets the Rowguid field. </summary>
		public System.Guid Rowguid { get; set; }
		/// <summary>Represents the navigator which is mapped onto the association 'EmailAddress.Person - Person.EmailAddresses (m:1)'</summary>
		public virtual Person Person { get; set; }
	}
}
