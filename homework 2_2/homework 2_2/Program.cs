using System;

namespace List
{
	class Program
	{
		static void Main(string[] args)
		{
			List list = new List();
			list.Add(1);
			list.Add(2);
			list.Add(10);
			list.Show();
			list.DeleteElement(5);
			list.DeleteElement(4);
			list.DeleteElement(7);
			list.DeleteElement(2);
			list.DeleteElement(10);
			list.Show();
			list.Add(15);
			list.Show();
			list.Add(0);
			list.Show();
			Console.WriteLine(list.Search(1));
			Console.WriteLine(list.Search(16));
		}
	}
}
