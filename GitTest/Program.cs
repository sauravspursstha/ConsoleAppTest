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
                    Console.WriteLine("hello");
                    break;
                case "Aakriti":
                    Console.WriteLine("hello");
                    break;
                case "Rosan":
                    Console.WriteLine("hello");
                    break;
                case "Samiksha":
                    Console.WriteLine("hello");
                    break;
            }

        }

        public static string EnterName()
        {
            Console.WriteLine("Enter your name:");
            string name = Console.Read().ToString();

            return name;
        }
    }
}
