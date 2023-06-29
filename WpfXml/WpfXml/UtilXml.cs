using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace WpfXml
{
   public class UtilXml
    {


        public static void TransformaXML(string xmlfile)
        { 
            WriteXMLText(ReadXMLText(xmlfile));
        }

        //escribir un txt
        public static void WriteXML(ResultadoJSON miarch)
        { 
        //escribir un txt
            File.WriteAllText("appsettings.txt", System.Text.Json.JsonSerializer.Serialize(miarch));
        }

        public static void WriteXMLText(string miarch)
        {
            //escribir un txt
            File.WriteAllText("appsettings.txt", miarch.Replace("\\", "\\\\"));
        }

        //leer un xml
        public static ResultadoJSON ReadXML(string xmlfile)
        {
            XmlReaderSettings settings = new XmlReaderSettings
            {
                IgnoreWhitespace = true,
                ValidationType = ValidationType.None
            };

            ResultadoJSON _res = new     ResultadoJSON();
            List<Parameter> _lst = new List<Parameter>();

            using (var fileStream = File.OpenText(xmlfile))
            using (XmlReader reader = XmlReader.Create(fileStream, settings))
            {
                bool cfg;
                while (cfg = reader.ReadToFollowing("add"))
                {
                    string cfg_name = reader.GetAttribute("key");
                    string cfg_value = reader.GetAttribute("value");
                    Console.WriteLine(" Name:" + cfg_name + " Value: " + cfg_value);
                    Parameter p = new Parameter();
                    p.key = cfg_name;
                    p.value = cfg_value;
                    _lst.Add(p);    
                }
            }
            _res.appSettings = _lst.ToArray();  

            return _res;
        }


        public static string ReadXMLText(string xmlfile)
        {
            XmlReaderSettings settings = new XmlReaderSettings
            {
                IgnoreWhitespace = true,
                ValidationType = ValidationType.None
            };
            System.Text.StringBuilder _lst = new   StringBuilder();
            _lst.AppendLine("appSettings : {");
            using (var fileStream = File.OpenText(xmlfile))
            using (XmlReader reader = XmlReader.Create(fileStream, settings))
            {
                bool cfg;
                while (cfg = reader.ReadToFollowing("add"))
                {
                    string cfg_name = reader.GetAttribute("key");
                    string cfg_value = reader.GetAttribute("value");
                    Console.WriteLine(" Name:" + cfg_name + " Value: " + cfg_value);
                    //    Parameter p = new Parameter();
                    //    p.key = cfg_name;
                    //    p.value = cfg_value;
                    //    _lst.Add(p);
                    _lst.AppendLine($"\"{cfg_name}\" : \"{cfg_value}\",");
                }
            }
            _lst.AppendLine("}");
            string _res = _lst.ToString();
            if (_res.LastIndexOf(",") > 0)
           _res =     _res.Remove(_res.LastIndexOf(","), 1);   


            return _res;
        }
    }

}
