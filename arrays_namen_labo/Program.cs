using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arrays_namen_labo
{
    internal class Program
    {
        static void Main(string[] args)
        {

            

            Console.WriteLine("==== Namen in een array stockeren en afdrukken ====");

            Console.WriteLine("");

            Console.WriteLine($"Hoeveel namen wens je te beheren?");
            int inputUser = int.Parse(Console.ReadLine());

            Console.WriteLine($"Voer nu {inputUser} namen in!");

            string[] namen = new string[inputUser];

            for (int i = 0; i < namen.Length; i++)
            {
                Console.WriteLine($"Naam {i+1}/{inputUser}: {namen[i] = Console.ReadLine()}");
            }

            Console.WriteLine("");

            Console.WriteLine("Wens je de namen af te drukken? Druk dan op eender welke knop! \n");
            Console.ReadKey();

            Console.WriteLine(" ====Namen afdrukken ==== \n");

            for (int i = 0; i < namen.Length; i++)
            {
                Console.WriteLine($"Naam {i+1} is {namen[i].ToUpper()}");
            }

            Console.ReadLine();

        }
    }
}
