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
                case "Roshan":
                    Console.WriteLine(Roshan());
                    break;
                default:
                    Console.WriteLine("Enter correct name!!");
                    break;
            }

        }

        public static string EnterName()
        {
            Console.WriteLine("Enter your name:");
            string name = Console.ReadLine().ToString();
            return name;
        }

        public static string Roshan()
        {
            return "Welcome";
        }
    }
}
