using System;
using System.IO;
using System.Xml.Serialization;

namespace SerializationTest
{
    class Program
    {
        static void Main(string[] args)
        {
            //function.XMLSerialize();
            function.XMLDeserialize();
        }
    }
    public class function
    {
        public static void XMLSerialize()
        {
            //Person c = new Person("cyj");
            //c.Courses = new Course[2];
            //c.Courses[0] = new Course("英语", "交流工具");
            //c.Courses[1] = new Course("数学", "自然科学");
            //XmlSerializer xs = new XmlSerializer(typeof(Person));
            //Stream stream = new FileStream("e:\\cyj.m", FileMode.Create, FileAccess.Write, FileShare.Read);
            //xs.Serialize(stream, c);
            //stream.Close();
        }
        public static void XMLDeserialize()
        {
            XmlSerializer xs = new XmlSerializer(typeof(TMAS));
            Stream stream = new FileStream("E:\\bbb.tmas.m", FileMode.Open, FileAccess.Read, FileShare.Read);
            TMAS m = xs.Deserialize(stream) as TMAS;
            Console.ReadLine();
            stream.Close();
            var uuid = Guid.NewGuid().ToString();
        }
    }    
}