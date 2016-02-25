using System;
using System.Collections.Generic;

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
			list.DeleteElement(5);
			list.DeleteElement(4);
			list.DeleteElement(7);
			list.DeleteElement(2);
			list.DeleteElement(10);
			list.Show();
			Console.WriteLine(list.IsInTheList(1));
			Console.WriteLine(list.IsInTheList(16));
		}
	}

	class List
	{
		private int number = 0;

		private List<int> list = new List<int>();

		public void Add(int value) // adds elements to the list
		{
			list.Add(value);
			number++;
		}

		public void DeleteElement(int value) // takes elements off the list and shows them
		{
			if (IsInTheList(value) == true)
			{
				list.Remove(value);
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
					return true;
				}
			}
			return false;
		}
	}
}
