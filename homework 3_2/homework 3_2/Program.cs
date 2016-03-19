using System;

namespace NewHashTable
{
	class Program
	{
		static public void Main()
		{
			HashInterface hash;
			HashTable hashTable;
			Console.WriteLine("Type:\n '1' to use the first function,\n '2' to use the second function.");
			int command = Convert.ToUInt16(Console.ReadLine());
			while (command > 2)
			{
				Console.WriteLine("Wrong input! Try again.");
				command = Convert.ToUInt16(Console.ReadLine());
			}
			if (command == 1)
			{
				hash = new SecondHash();
			}
			else
			{
				hash = new SecondHash();
			}
			hashTable = new HashTable(hash);
			hashTable.Add(1);
			for (int i = 0; i < 1000; ++i)
			{
				hashTable.Add(51 * i);
			}
			Console.WriteLine(hashTable.Search(33));
			Console.WriteLine(hashTable.Search(102));
			hashTable.DeleteElement(51);
			hashTable.DeleteElement(0);
			Console.WriteLine(hashTable.Search(0));
		}
	}
}