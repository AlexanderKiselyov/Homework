using System;

namespace HashTable
{
	class Program
	{
		static void Main(string[] args)
		{
			HashTable hash = new HashTable();
			hash.Add(10);
			hash.Add(95);
			hash.Add(80);
			hash.Add(1);
			hash.Show();
			hash.DeleteElement(95);
			hash.DeleteElement(5);
			hash.Show();
			Console.WriteLine(hash.Search(1));
			Console.WriteLine(hash.Search(2));
			hash.DeleteElement(80);
			hash.Show();
			hash.DeleteElement(10);
			hash.DeleteElement(1);
			hash.DeleteElement(78);
			hash.Show();
			Console.WriteLine(hash.Search(95));
		}
	}
}