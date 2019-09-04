using System;

namespace Tree
{
	class Program
	{
		public static void Main()
		{
			Tree tree = new Tree("( * ( + 1 1 ) 2 )");
			tree.Print();
			Console.WriteLine("= " + tree.Calculate());
		}
	}
}