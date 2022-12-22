using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace File_Directory.Models
{
    internal class Names
    {
        static int _id;

        public int Id { get; set; }
        public string Name { get; set; }

        public Names()
        {
            Id = _id;
            _id++;
        }

        public static void AddMethod(string name, string path)
        {
            using(StreamWriter stream= new StreamWriter(path))
            {
                stream.WriteLine(path);
            }
        }
        public static bool SearchMethod(string name, string path)
        {
            using(StreamReader stream= new StreamReader(path))
            {
                foreach(var item in path)
                {
                    Console.WriteLine("Axtarir siyahini");
                    stream.ReadToEnd();
                    return false;
                }
            }
            return true;
        }
    }
}
