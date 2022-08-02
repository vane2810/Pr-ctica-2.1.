using System;

namespace Práctica_2._2
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = 5;
            int num2 = 27;
            var suma = num1 + num2;
            int edad = 18;
            string name = "Vanessa";

            Console.WriteLine(suma);
            Console.WriteLine("Su nombre es : {1} y su edad es : {0} " , edad , name );
        }
    }
}