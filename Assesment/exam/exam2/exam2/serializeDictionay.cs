using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exam2
{
    
    class serializeDictionay
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> points = new Dictionary<string, int>
            {
                { "Jay", 1000 },
                { "Amit", 2000 },
                { "Gaurav", 3000 }
            };

            string json = JsonConvert.SerializeObject(points, Formatting.Indented);

            Console.WriteLine(json);
            Console.WriteLine("dictionary serialized successfully");
            Console.Read();
            
        }
    }
}
