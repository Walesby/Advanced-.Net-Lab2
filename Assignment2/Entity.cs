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
    /// Is the base abstract class that organization, person, patient and provider all derive from
    /// Has 0..* Addresses and Has 0..* Identifiers
    /// </summary>
    [XmlRoot]
    [XmlType]
    [JsonObject]
    [Serializable]
    public abstract class Entity
    {
        // This region holds all the properties of an Entity
        #region
        [XmlElement]
        [JsonProperty]
        public Guid Id {get; set;}
        public Identifier Identifier { get; set; }
        public Address Address { get; set; }
        #endregion     

        // This region holds all the constructors of an Entity
        #region
        protected Entity() { }
        protected Entity(Guid id)
        {
            Id = id;
        }
        protected Entity(Guid id, Identifier identifier)
        {
            Id = id;
            Identifier = identifier;
        }
        protected Entity(Guid id, Address address)
        {
            Id = id;
            Address = address;
        }
        protected Entity(Guid id, Identifier identifier, Address address)
        {
            Id = id;
            Identifier = identifier;
            Address = address;
        }
        #endregion
    }
}
