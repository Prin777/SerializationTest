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
        public static void XMLSerialize(TMAS t)
        {
            Stream stream = new FileStream("e:\\new.tmas.m", FileMode.Create, FileAccess.Write, FileShare.Read);
            //去除默认命名空间xmlns:xsd和xmlns:xsi
            XmlSerializerNamespaces ns = new XmlSerializerNamespaces();
            ns.Add("", "");
            XmlSerializer xs = new XmlSerializer(typeof(TMAS));
            xs.Serialize(stream, t, ns);
            stream.Close();
        }
        
        public static void XMLDeserialize()
        {
            XmlSerializer xs = new XmlSerializer(typeof(TMAS));
            Stream stream = new FileStream("e:\\000aaa.tmas.m", FileMode.Open, FileAccess.Read, FileShare.Read);
            TMAS m = xs.Deserialize(stream) as TMAS;
            function.XMLSerialize(m);
            Console.ReadLine();
            stream.Close();
        }
    }    
}