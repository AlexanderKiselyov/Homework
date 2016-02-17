using System;

namespace д.з._1_1
{
    class Program
    {
	static int factorial(int result, int n)
	{
        for (int i = 1; i <= n; i++)
        {
            result *= i;
        }
		return result;
	}
	static void Main(string[] args)
        {
			Console.WriteLine ("Write number: ");
			int n = int.Parse (Console.ReadLine ());
			int result = 1;
			result = factorial(result, n);
            Console.WriteLine("The result is: ");
            Console.WriteLine(result);
        }
    }
}
