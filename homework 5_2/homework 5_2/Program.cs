using System;
using System.Collections.Generic;

namespace Filter
{
	class Program
	{
		static void Main()
		{
			List<int> list = FilterFunction.Filter(new List<int>() { 1, 2, 3 }, x => { return x % 2 == 0; });
			Console.WriteLine("New elements:");
			foreach (int element in list)
			{
				Console.Write("{0} ", element);
			}
			Console.WriteLine();
		}
	}
}
