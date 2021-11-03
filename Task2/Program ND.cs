using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        { 
            String skaiciusPirmas;
           

            Console.WriteLine("Enter first number:");
            skaiciusPirmas = Console.ReadLine();
            Console.WriteLine("Enter second number:");
            String skaiciusAntras = Console.ReadLine();

            float result = float.Parse(skaiciusPirmas) + int.Parse(skaiciusAntras);

            Console.WriteLine($"Sum is: {result}"); // "result" is variable name;

            Console.ReadLine();

            var number1 = int.Parse(Console.ReadLine());


          
        }
    }
}


