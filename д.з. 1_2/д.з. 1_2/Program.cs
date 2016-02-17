using System;

namespace д.з._1_2
{
    class Program
    {
        static int fibonacci(int n)
        {
            if ((n == 1) || (n == 2))
            {
                return 1;
            }
            else
            {
                return (fibonacci(n - 1) + fibonacci(n - 2));
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Write number: ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("The result is: ");
            Console.WriteLine(fibonacci(n));
        }
    }
}

