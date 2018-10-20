using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exam2
{
    class file4
    {
        public static void test()
        { 
}
        static void Main(string[] args)
        {
            try
            {
                string text = File.ReadAllText(@"D:\\HTMLoffice\\Assesment\\abc.txt");
                string s1 = Console.ReadLine();
                string s2 = Console.ReadLine();
                text = text.Replace(s1, s2);
                File.WriteAllText(@"D:\\HTMLoffice\\Assesment\\abc.txt", text);
            }
            catch(FileNotFoundException)
            {
                string text = File.ReadAllText(@"D:\\HTMLoffice\\Assesment\\abc.txt");
                string s1 = Console.ReadLine();
                string s2 = Console.ReadLine();
                text = text.Replace(s1, s2);
                File.WriteAllText(@"D:\\HTMLoffice\\Assesment\\abc.txt", text);
                
            }
            catch(Exception e)
            {
                Console.WriteLine("Ooops...something went wrong please try again later: " + e);
            }
            Console.Read();
            
        }
    }
}
