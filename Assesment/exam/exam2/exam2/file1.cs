using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exam2
{
    class file1
    {
        static void Main(string[] args)
        {
            try
            {
                string s1 = Console.ReadLine();
                  
                string loc = "D:\\HTMLoffice\\Assesment\\"+ s1 +".txt";
                 
                FileInfo file = new FileInfo(loc);
                  
                file.Create();
                Console.WriteLine("File is created Successfuly");
            }
            catch (IOException e)
            {
                Console.WriteLine("Something went wrong: " + e);
            }
        }
    }
}
