using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace GoF_Patterns.Composite.OwnExample
{
    public static class ComponentXmlSerializer
    {
        private static string XmlDataFileDirectory = "CompositeTest/";
        private static string UsXmlFileName = "CompositeTest.xml";
        private static XmlSerializer _usXmlSerializer = new XmlSerializer(typeof(List<AComponent>));

        public static List<AComponent> ReadUsList(List<AComponent> defaultUss = null)
        {
            try
            {
                if (!Directory.Exists(XmlDataFileDirectory))
                    Directory.CreateDirectory(XmlDataFileDirectory);

                if (!File.Exists(XmlDataFileDirectory + UsXmlFileName))
                {
                    WriteUsList(defaultUss);

                    Console.WriteLine("New xml file was created, use 'Add New User Story' mode in Main Menu to add data.");
                    Console.WriteLine($"Filepath: {XmlDataFileDirectory + UsXmlFileName}");
                }

                using (var reader = XmlReader.Create(XmlDataFileDirectory + UsXmlFileName))
                {
                    var uss = (List<AComponent>)_usXmlSerializer.Deserialize(reader);
                    return uss;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message); 
                return null;
            }
        }

        public static void WriteUsList(List<AComponent> uss, bool writeToTestFile = false)
        {
            var xmlWriterSettings = new XmlWriterSettings() { Indent = true };
            string fileName = XmlDataFileDirectory + UsXmlFileName;

            if (writeToTestFile)
            {
                fileName = XmlDataFileDirectory + DateTime.Now.Ticks.ToString() + "_" + UsXmlFileName;
            }

            using (var writer = XmlWriter.Create(fileName, xmlWriterSettings))
            {
                _usXmlSerializer.Serialize(writer, uss);
            }
        }
    }
}
