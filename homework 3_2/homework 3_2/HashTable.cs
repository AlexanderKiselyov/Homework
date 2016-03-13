namespace NewHashTable
{
	/// counts hash function for the element and add it to the array. Also can delete elements from the hash table, search them in it and show hash table.
	public class HashTable
	{
		private HashInterface hash;
		private const int hashConstant = 100;
		private List[] list;

		public HashTable(HashInterface hash)
		{
			this.hash = hash;
			list = new List[hashConstant];
			for (int i = 0; i < hashConstant; ++i)
			{
				list[i] = new List();
			}
		}

		/// counts hash function
		private int HashFunction(int value)
		{
			return hash.Function(value, hashConstant);
		}

		/// adds elements with their hash to the table
		public void Add(int value)
		{
			list[HashFunction(value)].Add(value);
		}

		/// deletes elements with their hash from the table
		public void DeleteElement(int value)
		{
			list[HashFunction(value)].DeleteElement(value);
		}

		// searchers for the elements in the table
		public bool Search(int value)
		{
			return list[HashFunction(value)].Search(value);
		}

		/// shows elements
		public void Print()
		{
			for (int i = 0; i < hashConstant; ++i)
			{
				list[i].Print();
			}
		}
	}
}