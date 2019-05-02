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
    /// Represents an Address.
    /// </summary>
    [XmlRoot]
    [XmlType]
    [JsonObject]
    [Serializable]
    public class Address 
    {
        // This region holds all the properties of an Address
        #region
        /// <summary>
        /// Gets or sets the AddressLine
        /// </summary>
        /// <value>The address line</value>
        [XmlElement]
        [JsonProperty]
        public string AddressLine { get; set; }

        /// <summary>
        /// Gets or sets the City
        /// </summary>
        /// <value>The city</value>
        [XmlElement]
        [JsonProperty]
        public string City { get; set; }

        /// <summary>
        /// Gets or sets the Country
        /// </summary>
        /// <value>The country</value>
        [XmlElement]
        [JsonProperty]
        public string Country { get; set; }

        /// <summary>
        /// Gets or sets the PostalCode
        /// </summary>
        /// <value>The postal code</value>
        [XmlElement]
        [JsonProperty]
        public string PostalCode { get; set; }

        /// <summary>
        /// Gets or sets the Province
        /// </summary>
        /// <value>The province</value>
        [XmlElement]
        [JsonProperty]
        public string Province { get; set; }
        #endregion

        // This region holds all the constructors for an Address
        #region
        /// <summary>
        /// Required for XML serialization and deserialization
        /// </summary>
        public Address()
        {

        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Address" /> class.
        /// </summary>
        public Address(string adressLine, string city, string province, string country, string postalCode)
        {
            AddressLine = adressLine;
            City = city;
            Country = country;
            PostalCode = postalCode;
            Province = province;
        }       
        #endregion
    }
}
