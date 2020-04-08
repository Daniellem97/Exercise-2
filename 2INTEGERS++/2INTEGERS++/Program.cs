using System;

namespace _2INTEGERS__
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Write a number, this number will automatically be incremented by one");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Write another number to be added to your first number");
            int num2 = int.Parse(Console.ReadLine());
            int num3 = ++num1;
            int answer = num2 + num3;
            Console.WriteLine(answer);
        }
    }
}
