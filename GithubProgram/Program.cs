using System;

namespace PracticaGib
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            int a = 0,b = 0;

            Console.WriteLine("Enter a value for a: ");
            a = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Enter a value for b: ");
            b = Int32.Parse(Console.ReadLine());
            //camcbio de signo a multiplicacion 
            Console.WriteLine($"adding {a} * {b} equals {AddNumbers(a, b)}");
        }

        public static int AddNumbers(int a, int b)
        {

            //Cambio de signo para retornar una multiplicacion
            return a * b;
        }
    }
}