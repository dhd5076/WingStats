using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Json;
using System.IO;

namespace WingStats
{
    class Program
    {
        static void Main(string[] args)
        {
            JsonParser JSONParser = new JsonParser();
            string wingStatFile = File.ReadAllText("message.json");
            object wingStatObject = JsonParser.Deserialize(wingStatFile);
            Console.Write(wingStatObject);
            Console.Read();
        }
    }
}
