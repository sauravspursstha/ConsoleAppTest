using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitTest
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = EnterName();

            switch (name)
            {
                case "Saurav":
                    Console.WriteLine(Saurav());
                    Console.ReadLine();
                    break;
              
                default:
                    Console.WriteLine("Sorry mate");
                    break;
               
            }

        }

        public static string EnterName()
        {
            Console.WriteLine("Enter your name:");
            string name = Console.ReadLine().ToString();

            return name;
        }

        public static string Saurav()
        {
            return "Saurav";
        }
    }
}
