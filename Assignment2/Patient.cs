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
	/// Represents a Patient.
    /// Inherits from Person which inherits from Entity.
	/// </summary>
    [XmlRoot]
    [XmlType]
    [JsonObject]
    [Serializable]
    public class Patient : Person
    {
        // This region has all the properties of a Patient
        #region
        /// <summary>
        /// Gets or sets the DateOfBirth.
        /// </summary>
        /// <value>The date of birth.</value>
        [XmlIgnore]
        [JsonIgnore]
        public DateTimeOffset DateOfBirth{ get; set; }
        /// <summary>
        /// Gets or sets the DateOfBirth for XML serialization
        /// </summary>
        [XmlElement]
        [JsonProperty]
        public string DateOfBirthXml
        {
            get
            {
                return this.DateOfBirth.ToString("o");
            }
            set
            {
                value = this.DateOfBirth.ToString("o");
            }
        }
        /// <summary>
		/// Gets or sets the Gender.
		/// </summary>
		/// <value>The gender.</value>
        [XmlElement]
        [JsonProperty]
        public string Gender{ get; set; }
        #endregion

        // This region holds the required empty constructor for XML serialization and deserialization 
        #region
        /// <summary>
        /// Required for XML serialization and deserialization
        /// </summary>
        public Patient()
        {

        }
        #endregion

        // This region holds all the Patient constructors without a middle name
        #region
        /// <summary>
        /// Initializes a new instance of the <see cref="Patient" /> class without a middle name.
        /// </summary>
        public Patient(DateTimeOffset dateOfBirth, string gender, string firstName, string lastName, Guid id) : base(firstName, lastName, id)
        {
            DateOfBirth = dateOfBirth;
            Gender = gender;
        }
        public Patient(DateTimeOffset dateOfBirth, string gender, string firstName, string lastName, Guid id, Address address) : base(firstName, lastName, id, address)
        {
            DateOfBirth = dateOfBirth;
            Gender = gender;
        }
        public Patient(DateTimeOffset dateOfBirth, string gender, string firstName, string lastName, Guid id, Identifier identifier) : base(firstName, lastName, id, identifier)
        {
            DateOfBirth = dateOfBirth;
            Gender = gender;
        }
        public Patient(DateTimeOffset dateOfBirth, string gender, string firstName, string lastName, Guid id, Identifier identifier, Address address) : base(firstName, lastName, id, identifier , address)
        {
            DateOfBirth = dateOfBirth;
            Gender = gender;
        }
        #endregion

        // This region holds all the Patient constructors that have a middle name
        #region
        /// <summary>
        /// Initializes a new instance of the <see cref="Patient" /> class with a middle name.
        /// </summary>
        public Patient(DateTimeOffset dateOfBirth, string gender, string firstName, string middleName, string lastName, Guid id) : base(firstName, middleName, lastName, id)
        {
            DateOfBirth = dateOfBirth;
            Gender = gender;
        }
        public Patient(DateTimeOffset dateOfBirth, string gender, string firstName, string middleName, string lastName, Guid id, Identifier identifier) : base(firstName, middleName, lastName, id, identifier)
        {
            DateOfBirth = dateOfBirth;
            Gender = gender;
        }
        public Patient(DateTimeOffset dateOfBirth, string gender, string firstName, string middleName, string lastName, Guid id, Address address) : base(firstName, middleName, lastName, id, address)
        {
            DateOfBirth = dateOfBirth;
            Gender = gender;
        }
        public Patient(DateTimeOffset dateOfBirth, string gender, string firstName, string middleName, string lastName, Guid id, Identifier identifier, Address address) : base(firstName, middleName, lastName, id, identifier, address)
        {
            DateOfBirth = dateOfBirth;
            Gender = gender;
        }
        #endregion

    }
}
