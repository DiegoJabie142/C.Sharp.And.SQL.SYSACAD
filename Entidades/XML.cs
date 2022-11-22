using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Entidades
{
    public static class XML
    {
        private static StreamWriter writer;
        private static StreamReader reader;
        public static XmlSerializer serializer;
        private static string path;
        private static string xmlDefaultPath;

        static XML()
        {
            XML.path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            xmlDefaultPath = XML.path;
        }

        public static bool SerializarXml(List<Alumno> lista, string materia)
        {
            bool retorno = false;
            try
            {
                XML.path = xmlDefaultPath + $"\\{materia}.xml";

                using (XML.writer = new StreamWriter(XML.path))
                {
                    XML.serializer = new XmlSerializer(typeof(List<Alumno>));

                    XML.serializer.Serialize(XML.writer, lista);
                }
                retorno = true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return retorno;
        }

        public static List<Alumno> DeserializarXml(string materia)
        {
            List<Alumno> aux = new List<Alumno>();
            try
            {
                XML.path = xmlDefaultPath + $"\\{materia}.xml";
                using (XML.reader = new StreamReader(XML.path))
                {
                    XML.serializer = new XmlSerializer(typeof(List<Alumno>));

                    aux = (List<Alumno>)XML.serializer.Deserialize(XML.reader);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return aux;
        }
    }
}
