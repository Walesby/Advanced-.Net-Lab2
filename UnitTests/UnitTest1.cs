using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Assignment2;
using System.Reflection;

namespace UnitTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void XMLSerializationTest()
        {
            Assignment2Serializer assignment2Serializer = new Assignment2Serializer();
            Guid id = Guid.NewGuid();
            Guid orgId = Guid.NewGuid();
            DateTime thisDate = new DateTime(1993, 12, 21, 12, 21, 45);
            Identifier identifier = new Identifier("Highest", "GodKing");
            Address address = new Address("396 Upper Gage Avenue", "Hamilton", "Ontario", "Canada", "L8V4H9");
            var patient = new Patient(thisDate, "Male", "David", "James", "Walesby", id, identifier, address);
            var instanceXml = assignment2Serializer.SerializeToXml(patient, typeof(Patient));
            var actualValue = assignment2Serializer.DeserializeFromXml(instanceXml, typeof(Patient));
            Console.WriteLine(actualValue);
            Console.WriteLine(patient);
            Assert.AreEqual(patient, actualValue);
        }
        /// <summary>
        /// Tests to see if the id of the original object and the serialized object will be the same
        /// after changing the id of the original object after it has been serialized
        /// </summary>
        [TestMethod]
        public void XMLGenericSerializationTest()
        {
            Assignment2Serializer assignment2Serializer = new Assignment2Serializer();
            Guid id = Guid.NewGuid();
            Guid orgId = Guid.NewGuid();
            Identifier identifier = new Identifier("Great","Biggly");
            Address address = new Address("123 Fake", "Washerland", "Madagascar", "Iran", "T8F9I9");
            var organization = new Organization("GoGGl", id, identifier, address);
            var instanceXmlGeneric = assignment2Serializer.SerializeToXml<Organization>(organization);
            organization.Id = Guid.NewGuid();
            var actualValue = assignment2Serializer.DeserializeFromXml<Organization>(instanceXmlGeneric);
            Assert.AreNotEqual(organization.Id, actualValue.Id);
        }
        /// <summary>
        /// Tests to see if the original object and the JSON serialized and deserialized object will have the same guid
        /// Therefore are the same object
        /// Expected to pass
        /// </summary>
        [TestMethod]
        public void JSONGenericSerializationTest()
        {
            Assignment2Serializer assignment2Serializer = new Assignment2Serializer();
            Guid id = Guid.NewGuid();
            Guid orgId = Guid.NewGuid();
            DateTime thisDate = new DateTime(1993, 12, 21, 12, 21, 45);
            Identifier identifier = new Identifier("Highest", "GodKing");
            Address address = new Address("396 Upper Gage Avenue", "Hamilton", "Ontario", "Canada", "L8V4H9");
            var patient = new Patient(thisDate, "Male", "David", "James", "Walesby", id, identifier, address);
            var instanceJsonGeneric = assignment2Serializer.SerializeToJson<Patient>(patient);
            var actualValue = assignment2Serializer.DeserializeFromJson<Patient>(instanceJsonGeneric);

            Assert.AreEqual(patient.Id, actualValue.Id);
        }
        /// <summary>
        /// Test to see if the program will catch the JsonReaderException when deserializing from a Json file
        /// It will fail because the exception is caught
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(Newtonsoft.Json.JsonReaderException))]
        public void JSONSerializationErrorTest()
        {
            Assignment2Serializer assignment2Serializer = new Assignment2Serializer();
            var error = new Error() { Message = "HaHaHaHa"};
            var instanceJson = assignment2Serializer.SerializeToJson(error, typeof(Error));           
            var actualValue = assignment2Serializer.DeserializeFromJson(instanceJson, typeof(String));
          
        }
    }
    /// <summary>
    /// Represents an error
    /// Used to determine if the errors will happen during the serialization or deserilization process
    /// </summary>
    public class Error
    {
        public string Message { get; set; }
    }
}
