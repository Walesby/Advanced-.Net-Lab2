/*
 * Author - David Walesby, 000732130
 * Date - 2/24/2019
 * 
 * I David Walesby, 000732130 certify that this material is my original work,
 * and no other person's work has been used without due acknowledgement.
 */
using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;
using System.IO;

namespace Assignment2
{
    /// <summary>
    /// This library class is responsible for the methods that will serialize and deserialize objects
    /// In Json and XML
    /// </summary>
    public class Assignment2Serializer
    {
        /// <summary>
        /// Default constructor
        /// </summary>
        public Assignment2Serializer()
        {
            
        }
        /// <summary>
        /// A generic method attempts tries to deserialize a json file containg an object of Type T that is a derivative of an entity
        /// If it doesn't face an error it recieves a string with the file location named instance
        /// It then reads the file and deserializes the the json file object into an object of Type T
        /// It then returns the deserialized object of type T
        /// If it faces an error it returns null
        /// </summary>
        /// <typeparam name="T">Holds an object that is an Entity</typeparam>
        /// <param name="instance">Holds a string with the location of the file holding the serialized object</param>
        /// <returns>A deserialized object of Type T that is a derivitive of an entity</returns>
        /// <returns>If it encounters an error it returns null</returns>
        public T DeserializeFromJson<T>(string instance) where T : Entity
        {
            try
            {
                var serializer = new JsonSerializer();
                var bytes = File.ReadAllBytes(instance);
                var jsonReader = new JsonTextReader(new StringReader(Encoding.UTF8.GetString(bytes)));
                var deserializedObject = (T)serializer.Deserialize(jsonReader, typeof(T));

                return deserializedObject;
            }
            catch (ArgumentException e)
            {
                Console.WriteLine("Argument Exception");
            }
            catch (PathTooLongException e)
            {
                Console.WriteLine("Argument Exception");
            }
            catch (DirectoryNotFoundException e)
            {
                Console.WriteLine("Directory Not Found Exception");
            }
            catch (IOException e)
            {
                Console.WriteLine("IO Exception");
            }
            catch (UnauthorizedAccessException e)
            {
                Console.WriteLine("Unauthorized Access Exception");
            }
            catch (JsonReaderException e)
            {
                Console.WriteLine("Json Reader Exception");
            }
            return null;
        }

        /// <summary>
        /// A method that attempts to deserialize a json file containg an object of Type type
        /// It recieves a string with the file location name instance
        /// It then reads the file and deserializes the json file object into and object of Type type
        /// If it runs into an error it will stop and return null
        /// Else it then returns the deserialized object of Type type
        /// </summary>
        /// <param name="instance">Holds a string with the location of the file holding the serialized object</param>
        /// <param name="type">Holds the Type of the object that will be deserialized</param>
        /// <returns>The deserialized object of Type type</returns>
        /// <returns>If it encounters an error it returns null</returns>
        public object DeserializeFromJson(string instance, Type type)
        {
            var serializer = new JsonSerializer();
            try
            {
                var bytes = File.ReadAllBytes(instance);
                var jsonReader = new JsonTextReader(new StringReader(Encoding.UTF8.GetString(bytes)));
                var deserializedObject = serializer.Deserialize(jsonReader, type);

                return deserializedObject;
            }
            catch (ArgumentException e)
            {
                Console.WriteLine("Argument Exception");
            }
            catch (PathTooLongException e)
            {
                Console.WriteLine("Argument Exception");
            }
            catch (DirectoryNotFoundException e)
            {
                Console.WriteLine("Directory Not Found Exception");
            }
            catch (IOException e)
            {
                Console.WriteLine("IO Exception");
            }
            catch (UnauthorizedAccessException e)
            {
                Console.WriteLine("Unauthorized Access Exception");
            }
            catch (JsonReaderException e)
            {
                Console.WriteLine("Json Reader Exception");
            }
            return null;
        }

        /// A generic method that attempts to deserialize an XML file containg an object of Type T that is a derivative of an entity
        /// It recieves a string with the file location named instance
        /// It then reads the file and deserializes the the XML file object into an object of Type T
        /// If it runs into an error it will stop and return null
        /// Else it then returns the deserialized object of type T
        /// <typeparam name="T">Holds an object that is a derivitive of Entity</typeparam>
        /// <param name="instance">Holds a string with the location of the file holding the serialized object</param>
        /// <returns>A deserialized object of Type T that is a derivitive of an entity</returns>
        /// <returns>If it encounters an error it returns null</returns>
        public T DeserializeFromXml<T>(string instance) where T : Entity
        {
            try
            {
                var serializer = new XmlSerializer(typeof(T));
                var returnObject = File.ReadAllBytes(instance);
                var deserializedObject = (T)serializer.Deserialize(new MemoryStream(returnObject));
                return deserializedObject;
            }
            catch (ArgumentException e)
            {
                Console.WriteLine("Argument Exception");
            }
            catch (PathTooLongException e)
            {
                Console.WriteLine("Argument Exception");
            }
            catch (DirectoryNotFoundException e)
            {
                Console.WriteLine("Directory Not Found Exception");
            }
            catch (IOException e)
            {
                Console.WriteLine("IO Exception");
            }
            catch (UnauthorizedAccessException e)
            {
                Console.WriteLine("Unauthorized Access Exception");
            }
            return null;
        }

        /// <summary>
        /// A method that attempts to deserialize a XML file containg an object of Type type
        /// It recieves a string with the file location name instance
        /// It then reads the file and deserializes the XML file object into and object of Type type
        /// If it runs into an error it will stop and return null
        /// Else it then returns the deserialized object of Type type
        /// </summary>
        /// <param name="instance">Holds a string with the location of the file holding the serialized object</param>
        /// <param name="type">Holds the Type of the object that will be deserialized</param>
        /// <returns>The deserialized object of Type type</returns>
        /// <returns>If it encounters an error it returns null</returns>
        public object DeserializeFromXml(string instance, Type type)
        {
            try
            {
                var serializer = new XmlSerializer(type);
                var returnObject = File.ReadAllBytes(instance);
                var deserializedObject = serializer.Deserialize(new MemoryStream(returnObject));

                return deserializedObject;
            }
             catch (ArgumentException e)
            {
                Console.WriteLine("Argument Exception");
            }
            catch (PathTooLongException e)
            {
                Console.WriteLine("Argument Exception");
            }
            catch (DirectoryNotFoundException e)
            {
                Console.WriteLine("Directory Not Found Exception");
            }
            catch (IOException e)
            {
                Console.WriteLine("IO Exception");
            }
            catch (UnauthorizedAccessException e)
            {
                Console.WriteLine("Unauthorized Access Exception");
            }
            return null;
        }

        /// <summary>
        /// A generic method that attempts to serialize an object of Type T that is a derivative of Entity to a Json file
        /// If it runs into an error it will stop and return null
        /// Else it serializes to the Json file and then returns the location of the file as a string
        /// </summary>
        /// <typeparam name="T">Holds the Type of the object being provided</typeparam>
        /// <param name="instance">Holds the object of Type T</param>
        /// <returns>Returns a string with the file location that the object was serialized to</returns>
        /// <returns>If it encounters an error it returns null</returns>
        public string SerializeToJson<T>(T instance) where T : Entity
        {
            try
            {
                var jsonSerializer = new JsonSerializer();
                var stringWriter = new StringWriter();
                jsonSerializer.Serialize(stringWriter, instance);
                var serializedObject = Encoding.UTF8.GetBytes(stringWriter.ToString());
                File.WriteAllBytes($"{AppDomain.CurrentDomain.BaseDirectory}\\SerializeToJSONGeneric.json", serializedObject);

                return $"{AppDomain.CurrentDomain.BaseDirectory}\\SerializeToJSONGeneric.json";
            }
            catch (ArgumentException e)
            {
                Console.WriteLine("Argument Exception");
            }
            catch (PathTooLongException e)
            {
                Console.WriteLine("Argument Exception");
            }
            catch (DirectoryNotFoundException e)
            {
                Console.WriteLine("Directory Not Found Exception");
            }
            catch (IOException e)
            {
                Console.WriteLine("IO Exception");
            }
            catch (UnauthorizedAccessException e)
            {
                Console.WriteLine("Unauthorized Access Exception");
            }
            return null;
        }

        /// <summary>
        /// A method that attempts to serialize a provided object of Type type into a Json file
        /// If it runs into an error it will stop and return null
        /// Else it serializes to the Json file and then returns the location of the file as a string
        /// </summary>
        /// <param name="instance">Holds the object that will be serialized</param>
        /// <param name="type">Holds the Type of the object that will be serialized</param>
        /// <returns>Returns a string with the file location that the object was serialized to</returns>
        /// <returns>If it encounters an error it returns null</returns>
        public string SerializeToJson(object instance, Type type)
        {
            try
            {
                var jsonSerializer = new JsonSerializer();
                var stringWriter = new StringWriter();
                jsonSerializer.Serialize(stringWriter, instance);
                var serializedObject = Encoding.UTF8.GetBytes(stringWriter.ToString());
                File.WriteAllBytes($"{AppDomain.CurrentDomain.BaseDirectory}\\SerializeToJSON.json", serializedObject);

                return $"{AppDomain.CurrentDomain.BaseDirectory}\\SerializeToJSON.json";
            }
            catch (ArgumentException e)
            {
                Console.WriteLine("Argument Exception");
            }
            catch (PathTooLongException e)
            {
                Console.WriteLine("Argument Exception");
            }
            catch (DirectoryNotFoundException e)
            {
                Console.WriteLine("Directory Not Found Exception");
            }
            catch (IOException e)
            {
                Console.WriteLine("IO Exception");
            }
            catch (UnauthorizedAccessException e)
            {
                Console.WriteLine("Unauthorized Access Exception");
            }           
            return null;
        }

        /// <summary>
        /// A generic method that attempts to serialize an object of Type T that is a derivative of Entity to a XML file
        /// If it runs into an error it will stop and return null
        /// Else it serializes to the XML file and then returns the location of the file as a string
        /// </summary>
        /// <typeparam name="T">Holds the Type of the object being provided</typeparam>
        /// <param name="instance">Holds the object of Type T</param>
        /// <returns>Returns a string with the file location that the object was serialized to</returns>
        /// <returns>If it encounters an error it returns null</returns>
        public string SerializeToXml<T>(T instance) where T : Entity
        {
            try
            {
                var xmlSerializer = new XmlSerializer(typeof(T));
                var memoryStream = new MemoryStream();
                xmlSerializer.Serialize(memoryStream, instance);
                var serializedObject = memoryStream.ToArray();
                File.WriteAllBytes($"{AppDomain.CurrentDomain.BaseDirectory}\\SerializeToXmlGeneric.xml", serializedObject);

                return $"{AppDomain.CurrentDomain.BaseDirectory}\\SerializeToXmlGeneric.xml";
            }
            catch (ArgumentException e)
            {
                Console.WriteLine("Argument Exception");
                
            }
            catch (PathTooLongException e)
            {
                Console.WriteLine("Argument Exception");
                
            }
            catch (DirectoryNotFoundException e)
            {
                Console.WriteLine("Directory Not Found Exception");
                
            }
            catch (IOException e)
            {
                Console.WriteLine("IO Exception");
               
            }
            catch (UnauthorizedAccessException e)
            {
                Console.WriteLine("Unauthorized Access Exception");
               
            }
            return null;
        }

        /// <summary>
        /// A method that attempts to serialize an object of Type type into a XML file
        /// If it runs into an error it will stop and return null
        /// Else it serializes to the XML file and then returns the location of the file as a string
        /// </summary>
        /// <param name="instance">Holds the object that will be serialized</param>
        /// <param name="type">Holds the Type of the object that will be serialized</param>
        /// <returns>Returns a string with the file location that the object was serialized to</returns>
        /// <returns>If it encounters an error it returns null</returns>
        public string SerializeToXml(object instance, Type type)
        {
            try
            {
                var xmlSerializer = new XmlSerializer(type);
                var memoryStream = new MemoryStream();
                xmlSerializer.Serialize(memoryStream, instance);
                var serializedObject = memoryStream.ToArray();
                File.WriteAllBytes($"{AppDomain.CurrentDomain.BaseDirectory}\\SerializeToXml.xml", serializedObject);

                return $"{AppDomain.CurrentDomain.BaseDirectory}\\SerializeToXml.xml";
            }
            catch (ArgumentException e)
            {
                Console.WriteLine("Argument Exception");
            }
            catch (PathTooLongException e)
            {
                Console.WriteLine("Argument Exception");
            }
            catch (DirectoryNotFoundException e)
            {
                Console.WriteLine("Directory Not Found Exception");
            }
            catch (IOException e)
            {
                Console.WriteLine("IO Exception");
            }
            catch (UnauthorizedAccessException e)
            {
                Console.WriteLine("Unauthorized Access Exception");
            }
            return null;
        }
    }
}
