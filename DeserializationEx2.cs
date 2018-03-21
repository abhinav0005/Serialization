using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace Serialization
{
    class Player1
    {
        string name, Team;
        int Tno;
        public Player1(string name,string Team,int Tno)
        {
            this.name = name;
            this.Team = Team;
            this.Tno = Tno;
        }
    }
    class DeserializationEx2
    {
        static void Main(string[] args)
        {
            FileStream stream = new FileStream("F:\\FileIO\\zzz.txt", FileMode.OpenOrCreate);
            BinaryFormatter format = new BinaryFormatter();
            Player p1 = (Player)format.Deserialize(stream);
            Console.WriteLine("Player name : " + p1.name);
            Console.WriteLine("Team : " + p1.Team);
            Console.WriteLine("T-Shirt no. : " + p1.Tno);
            Console.WriteLine("Deserialization done..");
            Console.Read();
        }
    }
}
