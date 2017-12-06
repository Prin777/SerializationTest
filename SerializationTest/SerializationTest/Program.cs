using System;
using System.IO;
using System.Text;
using System.Xml;
using System.Xml.Serialization;

namespace SerializationTest
{
    class Program
    {
        static void Main(string[] args)
        {
            function.XMLDeserialize();

            //function.XMLSerialize();
        }
    }
    public class function
    {
        public static void XMLSerialize(TMASProject t)
        {
            Stream stream = new FileStream("e:\\new.tmas.m", FileMode.Create, FileAccess.Write, FileShare.Read);
            //去除默认命名空间xmlns:xsd和xmlns:xsi
            XmlSerializerNamespaces ns = new XmlSerializerNamespaces();
            ns.Add("", "");
            XmlSerializer xs = new XmlSerializer(typeof(TMASProject));
            xs.Serialize(stream, t, ns);
            stream.Close();
        }
        
        public static void XMLDeserialize()
        {
            XmlSerializer xs = new XmlSerializer(typeof(TMASProject));
            Stream stream = new FileStream("e:\\000aaa.tmas.m", FileMode.Open, FileAccess.Read, FileShare.Read);
            TMASProject m = xs.Deserialize(stream) as TMASProject;
            XMLSerialize(m);
            Console.ReadLine();
            stream.Close();
        }
    }    
}