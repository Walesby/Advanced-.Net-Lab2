/*
 * Author - David Walesby, 000732130
 * Date - 2/24/2019
 * 
 * I David Walesby, 000732130 certify that this material is my original work,
 * and no other person's work has been used without due acknowledgement.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using Newtonsoft.Json;
using System.Text;

namespace Assignment2
{
    /// <summary>
	/// Represents a person.
    /// Inherits from Entity.
	/// </summary>
    [XmlRoot]
    [XmlType]
    [JsonObject]
    [Serializable]
    public class Person : Entity
    {
        // This region holds all of the properties of a Person object
        #region
        /// <summary>
        /// Gets or sets the FirstName
        /// </summary>
        /// <value>The first name</value>
        [XmlElement]
        [JsonProperty]
        public string FirstName {get;set;}

        /// <summary>
        /// Gets or sets the MiddleName
        /// </summary>
        /// <value>The middleName</value>
        [XmlElement]
        [JsonProperty]
        public string MiddleName {get; set;}

        /// <summary>
        /// Gets or sets the LastName
        /// </summary>
        /// <value>The lastName</value>
        [XmlElement]
        [JsonProperty]
        public string LastName { get; set; }
        #endregion

        // This region holds the required empty constructor for XML serialization and deserialization
        #region
        /// <summary>
        /// This constructor is required for XML serialization and deserialization
        /// </summary>
        protected Person()
        {

        }
        #endregion

        // This region holds all of the Person constructors without a middle name
        #region
        /// <summary>
        /// Initializes a new instance of the <see cref="Person" /> class without a middleName, Address and Identifier.
        /// </summary>
        protected Person(string firstName, string lastName, Guid id) : base(id)
        {
            FirstName = firstName;
            MiddleName = "";
            LastName = lastName;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Person" /> class without a middleName and Address.
        /// </summary>
        protected Person(string firstName, string lastName, Guid id, Address address) : base(id, address)
        {
            FirstName = firstName;
            MiddleName = "";
            LastName = lastName;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Person" /> class without a middleName and Identifier.
        /// </summary>
        protected Person(string firstName, string lastName, Guid id, Identifier identifier) : base(id, identifier)
        {
            FirstName = firstName;
            MiddleName = "";
            LastName = lastName;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Person" /> class without a middleName.
        /// </summary>
        protected Person(string firstName, string lastName, Guid id, Identifier identifier, Address address) : base(id, identifier, address)
        {
            FirstName = firstName;
            MiddleName = "";
            LastName = lastName;
        }
        #endregion
        
        // This region holds all of the Person constructors with a middle name
        #region
        /// <summary>
        /// Initializes a new instance of the <see cref="Person" /> class with a middleName and without an Address and Identifier.
        /// </summary>
        protected Person(string firstName, string middleName, string lastName, Guid id): base (id)
        {
            FirstName = firstName;
            MiddleName = middleName;
            LastName = lastName;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Person" /> class with a middleName and without an Address.
        /// </summary>
        protected Person(string firstName, string middleName, string lastName, Guid id, Address address) : base(id,address)
        {
            FirstName = firstName;
            MiddleName = middleName;
            LastName = lastName;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Person" /> class with a middleName and without an Identifier.
        /// </summary>
        protected Person(string firstName, string middleName, string lastName, Guid id, Identifier identifier) : base(id, identifier)
        {
            FirstName = firstName;
            MiddleName = middleName;
            LastName = lastName;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Person" /> class with all properties
        /// </summary>
        protected Person(string firstName, string middleName, string lastName, Guid id, Identifier identifier, Address address) : base(id, identifier, address)
        {
            FirstName = firstName;
            MiddleName = middleName;
            LastName = lastName;
        }
        #endregion
    }
}
