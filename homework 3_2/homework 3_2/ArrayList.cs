namespace NewHashTable
{
	/// adds elements and deletes them
	public class ArrayList
	{
		private const int N = 100;
		private int[] list = new int[N];
		private int count = 0;
		private int pointer = 0;

		/// adds current value
		public void Add(int value)
		{
			list[count] = value;
			count++;
		}

		/// searches for value and deletes it if found
		public void DeleteElement()
		{
			for (int i = pointer; i < count - 1; i++)
			{
				list[i] = list[i + 1];
			}
			count--;
		}

		/// sets iterator with "0"
		public void SetIteratorFirst()
		{
			pointer = 0;
		}

		/// increments iterator
		public void MoveIterator()
		{
			pointer++;
		}

		/// compares iterator with the array size
		public bool IfIteratorNull()
		{
			return pointer == count;
		}

		/// returns value, which iterator points on
		public int ReturnValue()
		{
			if (!IfIteratorNull())
			{
				return list[pointer];
			}
			else
			{
				throw new ListNullException("Trying to get value from null in list.");
			}
		}
	}
}