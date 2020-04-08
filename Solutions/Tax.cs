using System;

namespace Tax
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter your name");
            string name = Console.ReadLine();
            Console.WriteLine("Please enter your age");
            int age = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter your gross pay");
            int pay = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter your tax rate");
            int tax = int.Parse(Console.ReadLine());

            int taxAmount = (pay / 100) * tax;
            int net = pay - taxAmount;

            Console.WriteLine("Your name is " + name);
            Console.WriteLine("You are " + age );
            Console.WriteLine("Your gross pay is " + pay + " with a tax rate of " +tax +"%");
            Console.WriteLine("Making your net pay " + net);

        }
    }
}
