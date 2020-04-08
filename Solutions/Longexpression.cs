using System;

namespace longexpression
{
    class Program
    {
        static void Main(string[] args)
        {
            int r = 1;
            int a = 1;
            int b = 1;
            int d = 1;
            int c = 1;
            int bc = b * c;
            int bd = b * d;

            double result1 = 3 * (r + 34);
            double result2 = 9 * (a + bc);
            double result3 = (d * (2 + a));
            double result4 = a + bd;
            double result5 = 4 / result1; 
            double result6 = result3 / result4; 
            double answer = result5 + 3 + result6 - result2;
            Console.WriteLine(answer); 

        }
    }
}
