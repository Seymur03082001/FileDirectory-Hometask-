using File_Directory.Models;
using System.Security.Cryptography.X509Certificates;
using System.Text.Json.Serialization;

namespace File_Directory
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = Path.Combine(Path.Combine(Directory.GetCurrentDirectory(), @"../../../", "Names"));
            Directory.SetCurrentDirectory(path);

            List<Names> list = new List<Names>();

            list.Add(new Names { Name = "Seymur"});
           

            path = Path.Combine(path, "names.json");
        }
    }
}