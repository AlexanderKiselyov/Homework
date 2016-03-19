namespace Calculator
{
	public class ListElement
	{
		private const int N = 100;
		private int[] list = new int[N];
		private int count = 0;
		private int pointer = 0;

		/// adds elements to the list
		public void Add(int value)
		{
			list[count] = value;
			count++;
		}

		/// takes elements off the list
		public void DeleteElement()
		{
			for (int i = pointer; i < count; i++)
			{
				list[i] = list[i + 1];
			}
			count--;
		}

		/// sets the iterator with "0" 
		public void SetIteratorFirst()
		{
			pointer = 0;
		}

		/// increments the iterator
		public void MoveIterator()
		{
			pointer++;
		}

		/// compares the iterator and the array size
		public bool IfIteratorNull()
		{
			return pointer == count;
		}

		/// sets iterator to the last element
		public void SetIteratorLast()
		{
			pointer = count - 1;
			if (pointer == -1)
			{
				pointer++;
			}
		}

		/// returns value of the array
		public int ReturnValue()
		{
			if (!IfIteratorNull())
			{
				return list[pointer];
			}
			else
			{
				return 0;
			}
		}
	}
}