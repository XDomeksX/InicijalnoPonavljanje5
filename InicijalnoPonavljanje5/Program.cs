using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InicijalnoPonavljanje5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Unesite link stranice: ");
            string URL = Console.ReadLine();

            if(URL.StartsWith("www.") && URL.EndsWith(".hr"))
            {
                Console.WriteLine("URL je ispravno napisan.");
            }
            else
            {
                Console.WriteLine("URL nije ispravno napisan.");
            }

            Console.ReadKey();
        }
    }
}
