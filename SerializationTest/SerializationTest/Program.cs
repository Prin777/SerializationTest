using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Xml.Serialization;

namespace SerializationTest
{
    class Program
    {
        static void Main(string[] args)
        {
            //function.XMLSerialize();
            function.XMLDeserialize();
            //function.SerializeNow();
            //function.DeSerializeNow();
        }
    }
    public class function
    {
        //public static void SerializeNow()
        //{
        //    ClassToSerialize c = new ClassToSerialize();
        //    FileStream fileStream =
        //    new FileStream("e:\\temp.dat", FileMode.Create);
        //    BinaryFormatter b = new BinaryFormatter();
        //    b.Serialize(fileStream, c);
        //    fileStream.Close();
        //    Console.WriteLine("二进制序列化完成。。。");
        //}
        //public static void DeSerializeNow()
        //{
        //    Console.WriteLine("开始二进制反序列化序列化");
        //    ClassToSerialize c = new ClassToSerialize();
        //    //c.Sex = "kkkk";
        //    FileStream fileStream =
        //    new FileStream("e:\\temp.dat",
        //    FileMode.Open, FileAccess.Read, FileShare.Read);
        //    BinaryFormatter b = new BinaryFormatter();
        //    c = b.Deserialize(fileStream) as ClassToSerialize;
        //    Console.WriteLine(c.id);
        //    Console.WriteLine(c.name);
        //    Console.WriteLine(c.Sex);
        //    fileStream.Close();
        //    Console.Read();
        //}

        public static void XMLSerialize()
        {
            Person c = new Person("cyj");
            c.Courses = new Course[2];
            c.Courses[0] = new Course("英语", "交流工具");
            c.Courses[1] = new Course("数学", "自然科学");
            XmlSerializer xs = new XmlSerializer(typeof(Person));
            Stream stream = new FileStream("e:\\cyj.m", FileMode.Create, FileAccess.Write, FileShare.Read);
            xs.Serialize(stream, c);
            stream.Close();
        }
        public static void XMLDeserialize()
        {
            XmlSerializer xs = new XmlSerializer(typeof(DOModule));
            Stream stream = new FileStream("E:\\abc.xml", FileMode.Open, FileAccess.Read, FileShare.Read);
            DOModule m = xs.Deserialize(stream) as DOModule;
        }
    }
    [Serializable]
    public class ClassToSerialize
    {
        public int id = 100;
        public string name = "Name";
        [NonSerialized]
        public string Sex = "男";
    }

    [Serializable]
    public class Person
    {
        private string name;
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }

        public string Sex;
        public int Age = 31;
        public Course[] Courses;
        public Person()
        {
        }
        public Person(string Name)
        {
            name = Name;
            Sex = "男";
        }
    }

    [Serializable]
    public class Course
    {
        public string Name;
        [XmlIgnore]
        public string Description;
        public Course()
        {
        }
        public Course(string name, string description)
        {
            Name = name;
            Description = description;
        }
    }

    [Serializable]
    [XmlRoot("DOModule")]
    public class DOModule
    {
        public DOModule()
        {
        }
        private string doobjects;
        [XmlElement(ElementName = "DOObjects")]
        public string DOObjects
        {
            get { return doobjects; }
            set { doobjects = value; }
        }
    }
}

