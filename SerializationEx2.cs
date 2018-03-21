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
    class Player
    {
        public string name,Team;
        public int Tno;
        public Player(string name, string Team, int Tno)
        {
            this.name = name;
            this.Team = Team;
            this.Tno = Tno;
        }
    }
    class SerializationEx2
    {
        static void Main(string[] args)
        {
            FileStream stream = new FileStream("F:\\FileIO\\zzz.txt", FileMode.OpenOrCreate);
            BinaryFormatter bftr = new BinaryFormatter();
            Player p1 = new Player("SACHIN", "INDIA", 10);
            bftr.Serialize(stream, p1);
            Console.WriteLine("data serialize...");
            Console.Read();
            stream.Close();
        }
    }
}
