using System;
using System.ComponentModel.Design;
using System.Globalization;

namespace Uppgift_4_23
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("skriv ett heltal");
            int tal = int.Parse(Console.ReadLine());

            int störst = tal;

            string svar = "";
            while (svar != "n")
            {
                Console.WriteLine("Vill du skriva heltal j/n");
                svar = Console.ReadLine();

                if (svar == "n")
                {
                    break;
                }

                Console.WriteLine("skriv in ett heltal"); 
                int nyttal = int.Parse(Console.ReadLine());  

                if (nyttal > störst)
                {
                    störst = nyttal;
                }

            }

            Console.WriteLine("Det största talet du skrev är " + störst);

          
            


        }
    }
}