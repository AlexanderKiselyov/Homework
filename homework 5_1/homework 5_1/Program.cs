using System;
using System.Collections.Generic;

namespace MapFunction
{
	class Program
	{
		public static void Main()
		{
			List<int> list = MapFunction.Map(new List<int>() { 1, 2, 3 }, x => x + 3);
			Console.WriteLine("New elements:");
			foreach (int element in list)
			{
				Console.Write("{0} ", element);
			}
			Console.WriteLine();
		}
	}
}
