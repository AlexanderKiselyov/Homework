using System;

namespace д.з._1_1
{
    class Program
    {
	private static int Factorial(int n) // counts the factorial of the number
	{
		int result = 1;
        	for (int i = 1; i <= n; i++)
        	{
            		result *= i;
        	}
		return result;
	}
	
	public static void Main(string[] args)
        {
        	Console.WriteLine("Write number:");
		int n = int.Parse(Console.ReadLine ());
		Console.WriteLine("The result is: ");
        	Console.WriteLine(Factorial(n));
        }
    }
}
