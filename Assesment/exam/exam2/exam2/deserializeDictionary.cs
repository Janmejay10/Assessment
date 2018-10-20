using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exam2
{
    public class deserializeDictionary
    {
        public string Name { get; set; }
        public int Year { get; set; }

        static void Main(string[] args)
        {
            // read file into a string and deserialize JSON to a type
            deserializeDictionary movie1 = JsonConvert.DeserializeObject<deserializeDictionary>(File.ReadAllText(@"D:\\C#.NET\\JSON\\movie.json"));

            // deserialize JSON directly from a file
            using (StreamReader file = File.OpenText(@"D:\\C#.NET\\JSON\\movie.json"))
            {
                JsonSerializer serializer = new JsonSerializer();
                deserializeDictionary movie2 = (deserializeDictionary)serializer.Deserialize(file, typeof(deserializeDictionary));
            }
            Console.Read();
        }
    }
}
