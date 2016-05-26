using System;

namespace ListAndStack
{
	class Program
	{
		static void Main()
		{
			var list = new List<int>();
			list.Push(10);
			list.Push(18);
			list.Push(35);
			list.Push(9);
			list.DeleteElement(18);
			list.DeleteElement(5);
			foreach (var element in list)
			{
				Console.WriteLine(element);
			}
		}
	}
}
