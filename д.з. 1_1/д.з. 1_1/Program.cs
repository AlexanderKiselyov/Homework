using System;

namespace д.з._1_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int result = 1;
            Console.WriteLine("Write number: ");
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                result *= i;
            }
            Console.WriteLine("The result is: ");
            Console.WriteLine(result);
        }
    }
}
