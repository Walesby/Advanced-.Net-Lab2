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
	/// Represents an Organization.
    /// Inherits from Entity.
	/// </summary>
    [XmlRoot]
    [XmlType]
    [JsonObject]
    [Serializable]
    public class Organization : Entity
    {
        // This region holds all the properties of an Organization
        #region
        /// <summary>
        /// Gets or sets the Name
        /// </summary>
        /// <value>The name</value>
        [XmlElement]
        [JsonProperty]
        public string Name { get; set; }
        #endregion      

        // This region holds all the Organization constructors
        #region
        /// <summary>
        /// Required for XML serialization and deserialization
        /// </summary>
        public Organization() { }

        /// <summary>
        /// Initializes a new instance of the <see cref="Organization" /> class.
        /// </summary>
        public Organization(string name, Guid id) : base(id) 
        {
            Name = name;
        }
        public Organization(string name, Guid id, Address address) : base(id, address)
        {
            Name = name;
        }
        public Organization(string name, Guid id, Identifier identifier) : base(id, identifier)
        {
            Name = name;
        }
        public Organization(string name, Guid id, Identifier identifier, Address address) : base(id, identifier, address)
        {
            Name = name;
        }
        #endregion

    }
}
