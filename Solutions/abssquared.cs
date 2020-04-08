using System;

namespace absquared
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 10;
            int b = 20;
            int ab = a*b;
            double absquared = Math.Pow(ab, 2);
           
            Console.WriteLine(absquared);

        }
    }
}
