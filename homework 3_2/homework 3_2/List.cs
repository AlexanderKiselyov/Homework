using System;

namespace NewHashTable
{
	/// can add elements to the hash table, delete them, show the whole list and search for the elements
	public class List
	{
		private ArrayList list = new ArrayList();

		/// adds new element to the list
		public void Add(int value)
		{
			list.Add(value);
		}

		/// deletes element with chosen value
		public void DeleteElement(int value)
		{
			list.SetIteratorFirst();
			while (!list.IfIteratorNull() && list.ReturnValue() != value)
			{
				list.MoveIterator();
			}
			if (!list.IfIteratorNull())
			{
				list.DeleteElement();
			}
		}

		/// prints the whole list
		public void Print()
		{
			list.SetIteratorFirst();
			while (!list.IfIteratorNull())
			{
				Console.Write(list.ReturnValue());
				Console.Write(' ');
				list.MoveIterator();
			}
			Console.WriteLine();
			list.SetIteratorFirst();
		}

		/// returns boolean value after searching for an element
		public bool Search(int value)
		{
			list.SetIteratorFirst();
			while (!list.IfIteratorNull())
			{
				if (list.ReturnValue() == value)
				{
					list.SetIteratorFirst();
					return true;
				}
				list.MoveIterator();
			}
			list.SetIteratorFirst();
			return false;
		}
	}
}