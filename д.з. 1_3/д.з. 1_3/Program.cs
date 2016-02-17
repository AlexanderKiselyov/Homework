using System;

namespace д.з._1_3
{
	class Program
	{
		const int n = 10;
		static void Main (string[] args)
		{
			char[] mass = new char[n];
			Console.WriteLine("Enter array of " + n + " elements:");
			for (int i = 0; i < n; i++)
			{
				mass[i] = char.Parse (Console.ReadLine ());
			}
			int length = mass.Length;
			for (int i = 0; i < length; i++)
			{
				for (int j = length - 1; j > i; j--)
				{
					if (mass[j - 1] > mass[j])
					{
						char current = mass[j - 1]; // bubble sort
						mass[j - 1] = mass[j];
						mass[j] = current;
					}
				}
			}
			Console.WriteLine ("New array:");
			for (int i = 0; i < length; i++)
			{
				Console.WriteLine(mass[i]);
			}
		}
	}
}
