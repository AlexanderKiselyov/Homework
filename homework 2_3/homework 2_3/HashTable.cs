using System;

namespace HashTable
{
	class HashTable
	{
		private static int hashConstant = 5;

		private List[] list;

		/// creates hashtable
		public HashTable()
		{
			list = new List[hashConstant];
			for (int i = 0; i < hashConstant; ++i)
			{
				list[i] = new List();
			}
		}

		/// creates hashfunction
		private static int HashFunction(int value)
		{
			return (value % hashConstant);
		}

		/// adds elements to the hashtable
		public void Add(int value)
		{
			list[HashFunction(value)].Add(value);
		}

		/// deletes elements from the hashtable
		public void DeleteElement(int value)
		{
			list[HashFunction(value)].DeleteElement(value);
		}

		/// checks if the element is in the hashtable
		public bool Search(int value)
		{
			return list[HashFunction(value)].Search(value);
		}

		/// shows elements of the hashtable
		public void Show()
		{
			Console.WriteLine("New array:");
			for (int i = 0; i < hashConstant; ++i)
			{
				list[i].Show();
			}
		}
	}
}
