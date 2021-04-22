using System;
using System.IO;
using MongoDB.Driver;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace XmlToMongoDb
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Child> result;
            string fileName = "random.xml";

            string currentDirectory = Environment.CurrentDirectory;
            string projectDirectory = Directory.GetParent(currentDirectory).Parent.Parent.FullName;
            string filePath = $"{projectDirectory}\\{fileName}";

            // Ignore the root element in the xml.
            XmlSerializer serializer = new XmlSerializer(typeof(List<Child>), new XmlRootAttribute("root"));

            Console.WriteLine($"Reading XML file with path: {filePath}");
            try
            {
                if (!string.IsNullOrWhiteSpace(filePath))
                {
                    // Read file and deserialize the xml.
                    using FileStream fileStream = new FileStream(filePath, FileMode.Open);
                    result = (List<Child>)serializer.Deserialize(fileStream);

                    if (result != null)
                    {
                        PopulateDB(result);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Exception occured while reading file: {ex}");
            }
        }

        private static void PopulateDB(List<Child> values)
        {
            try
            {
                IMongoDatabase mongoDatabase;
                IMongoCollection<Child> mongoCollection;

                string database = "TestDB";
                string collection = "Test";
                string connectionString = "mongodb://localhost:27017";

                // Creating the db connection.
                var client = new MongoClient(connectionString);

                if (client != null)
                {
                    mongoDatabase = client.GetDatabase(database);
                    mongoCollection = mongoDatabase.GetCollection<Child>(collection);

                    // Populating the db.
                    mongoCollection.InsertMany(values);
                    Console.WriteLine($"Data populated successfully in db: {database}");
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine($"Exception occured while populating db: {ex}");
            }
        }
    }
}
