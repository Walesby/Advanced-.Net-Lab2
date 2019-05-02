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
	/// Represents an Identifier.
	/// </summary>
    [XmlRoot]
    [XmlType]
    [JsonObject]
    [Serializable]
    public class Identifier 
    {
        // This region holds all the properties of an Identifier
        #region
        /// <summary>
        /// Gets or sets the Authority
        /// </summary>
        /// <value>The authority</value>
        [XmlElement]
        [JsonProperty]
        public string Authority {get; set;}
        /// <summary>
        /// Gets or sets the Value
        /// </summary>
        /// <value>The value</value>
        [XmlElement]
        [JsonProperty]
        public string Value {get; set;}
        #endregion

        // This region holds all the constructors of an Identifier
        #region
        /// <summary>
        /// Required for XML serialization and deserialization
        /// </summary>
        public Identifier() { }

        /// <summary>
        /// Initializes a new instance of the <see cref="Identifier" /> class.
        /// </summary>
        public Identifier(string authority, string value)
        {
            Authority = authority;
            Value = value;
        }
        #endregion

    }
    
}
