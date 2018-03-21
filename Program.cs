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
    class Student
    {
        public int rollNo;
        public string Sname;
        public Student(int rollNo, string Sname)
        {
            this.rollNo = rollNo;
            this.Sname = Sname;
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            FileStream stream = new FileStream("F:\\FileIO\\aaa.txt", FileMode.OpenOrCreate);
            BinaryFormatter f = new BinaryFormatter();
            Student s = new Student(5, "Abhinav");
            f.Serialize(stream, s);
            Console.WriteLine("Data serialization success...");
            Console.Read();
            stream.Close();
        }
    }
}
