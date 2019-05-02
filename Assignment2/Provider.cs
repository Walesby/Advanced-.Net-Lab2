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
	/// Represents a Provider.
    /// Inherits from Person which inherits from Entity.
	/// </summary>
    [XmlRoot]
    [XmlType]
    [JsonObject]
    [Serializable]
    public class Provider : Person
    {
        // This region holds all the properties of a Provider
        #region
        /// <summary>
        /// Gets or sets the Specialty.
        /// </summary>
        /// <value>The specialty.</value>
        [XmlElement]
        [JsonProperty]
        public string Specialty { get; set; }
        #endregion

        // This region holds the required empty constructor for XML serialization and deserialization
        #region
        /// <summary>
        /// Required for XML serialization and deserialization
        /// </summary>
        public Provider() { }
        #endregion

        // This region holds all the constructors of a Provider without a middle name
        #region
        /// <summary>
        /// Initializes a new instance of the <see cref="Provider" /> class without a middleName, Address and Identifier.
        /// </summary>
        public Provider(string specialty, string firstName, string lastName, Guid id) : base(firstName , lastName , id)
        {
            Specialty = specialty;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Provider" /> class without a middleName and Identifier.
        /// </summary>
        public Provider(string specialty, string firstName, string lastName, Guid id, Address address) : base(firstName, lastName, id, address)
        {
            Specialty = specialty;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Provider" /> class without a middleName and Address.
        /// </summary>
        public Provider(string specialty, string firstName, string lastName, Guid id, Identifier identifier) : base(firstName, lastName, id, identifier)
        {
            Specialty = specialty;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Provider" /> class without a middleName.
        /// </summary>
        public Provider(string specialty, string firstName, string lastName, Guid id, Identifier identifier, Address address) : base(firstName, lastName, id, identifier, address)
        {
            Specialty = specialty;
        }
        #endregion

        // This region holds all the constructors of a Provider with a middle name
        #region
        /// <summary>
        /// Initializes a new instance of the <see cref="Provider" /> class without an Address and Identifier.
        /// </summary>
        public Provider(string specialty, string firstName, string middleName, string lastName, Guid id) : base(firstName, middleName, lastName, id)
        {
            Specialty = specialty;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Provider" /> class without an Identifier.
        /// </summary>
        public Provider(string specialty, string firstName, string middleName, string lastName, Guid id, Address address) : base(firstName, middleName, lastName, id, address)
        {
            Specialty = specialty;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Provider" /> class without an Address.
        /// </summary>
        public Provider(string specialty, string firstName, string middleName, string lastName, Guid id, Identifier identifier) : base(firstName, middleName, lastName, id, identifier)
        {
            Specialty = specialty;
        }
        /// <summary>
        /// Initializes a new instance of the <see cref="Provider" /> class with all properties.
        /// </summary>
        public Provider(string specialty, string firstName, string middleName, string lastName, Guid id, Identifier identifier, Address address) : base(firstName, middleName, lastName, id, identifier, address)
        {
            Specialty = specialty;
        }
        #endregion
    }
}
