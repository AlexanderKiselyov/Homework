using System;

namespace List
{
	class Program
	{
		static void Main(string[] args)
		{
			HashFunction hash = new HashFunction();
			hash.HashTable();
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

	class HashFunction
	{
		private static int element = 10;

		private List[] list;

		public void HashTable() // creates new array
		{
			list = new List[element];
			for (int i = 0; i < element; i++)
			{
				list[i] = new List();
			}
		}

		private int Hash(int value) // counts hash of the element
		{
			return (value % element);
		}

		public void Add(int value) // adds element to the hashtable
		{
			list[Hash(value)].Add(value);
		}

		public void DeleteElement(int value) // deletes element from the hashtable
		{
			list[Hash(value)].DeleteElement(value);
		}

		public bool Search(int value) // searches for the element in the hashtable
		{
			return list[Hash(value)].IsInTheList(value);
		}

		public void Show() // shows elements
		{
			Console.WriteLine("The array:");
			for (int i = 0; i < element; i++)
			{
				list[i].Show();
			}
		}
	}

	class List
	{
		private int number = 0;

		private int position = 0;

		private static int count = 10;

		private int[] list = new int[count];

		public void Add(int value) // adds elements to the list
		{
			list[number] = value;
			number++;
		}

		public void DeleteElement(int value) // takes elements off the list and shows them
		{
			if (IsInTheList(value) == true)
			{
				for (int i = position; i < number; i++)
				{
					list[i] = list[i + 1];
				}
				number--;
			}
		}

		public void Show() // shows all the elements from the list
		{
			for (int i = 0; i < number; i++)
			{
				Console.Write(list[i]);
				Console.Write(' ');
			}
			Console.WriteLine();
		}

		public bool IsInTheList(int value) // checks if the elements is in the list
		{
			for (int i = 0; i < number; i++)
			{
				if (list[i] == value)
				{
					position = i;
					return true;
				}
			}
			return false;
		}
	}
}