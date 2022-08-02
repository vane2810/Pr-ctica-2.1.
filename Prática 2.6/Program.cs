using System;

namespace Prática_2._6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese un número:");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese otro número");
            int num2 = int.Parse(Console.ReadLine());
            var resta = num1 - num2;

            Console.WriteLine("La suma de los números es : {0}", resta);
        
        }
    }
}
