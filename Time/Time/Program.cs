using System;

namespace Time
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter time in seconds");
            int seconds = int.Parse(Console.ReadLine());
            int minutes = seconds / 60;
            double secondsRemaining = seconds%60;
            Console.WriteLine( minutes + " minutes " + secondsRemaining + " seconds");

           

        }
    }
}
