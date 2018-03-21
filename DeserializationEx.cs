using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace Serialization
{
    [Serializable]
    class Student1
    {
        public int rollNo;
        public string Sname;
        public Student1(int rollNo, string Sname)
        {
            this.rollNo = rollNo;
            this.Sname = Sname;
        }
    }
    class DeserializationEx
    {
        static void Main(string[] args)
        {
            FileStream stream = new FileStream("F:\\FileIO\\aaa.txt", FileMode.OpenOrCreate);
            BinaryFormatter format = new BinaryFormatter();
            Student s1 = (Student)format.Deserialize(stream);
            Console.WriteLine("Roll number : " + s1.rollNo);
            Console.WriteLine("Name : " + s1.Sname);
            Console.WriteLine("Deserialization done..");
            Console.Read();
        }
    }
}
