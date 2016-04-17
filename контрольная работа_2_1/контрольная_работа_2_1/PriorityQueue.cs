namespace PriorityQueue
{
	/// <summary>
	/// class that can add element with the priority to the queue and return it from the top
	/// </summary>
	class PriorityQueue
	{
		private const int maxSize = 100;
		private int[] array = new int[maxSize];
		private int[] priorityArray = new int[maxSize];
		private int size = 0;
		private int changingValue = 0;

		/// <summary>
		/// moves element forward if necessary
		/// </summary>
		private void Up(int i)
		{
			while (i != 0 && priorityArray[i] > priorityArray[(i - 1) / 2])
			{
				int currElement = array[i];
				array[i] = array[(i - 1) / 2];
				array[(i - 1) / 2] = currElement;
				i = (i - 1) / 2;
			}
		}

		/// <summary>
		///  moves element backward if necessary
		/// </summary>
		private void Down(int i)
		{
			while (i < size / 2)
			{
				int maxI = 2 * i + 1;
				if (2 * i + 2 < size && priorityArray[2 * i + 2] > priorityArray[2 * i + 1])
					maxI = 2 * i + 2;
				if (priorityArray[i] >= priorityArray[maxI])
				{
					return;
				}
				int chagingValue = array[i];
				array[i] = array[maxI];
				array[maxI] = chagingValue;
				i = maxI;
			}
		}

		/// <summary>
		/// adds element to the queue
		/// </summary>
		public void Enqueue(int value, int priority)
		{
			if (size + 1 == maxSize)
			{
				throw new OverloadException("Overload!");
			}
			array[size++] = value;
			priorityArray[size] = priority;
			Up(size - 1);
		}

		/// <summary>
		/// returns element from the queue and deletes it
		/// </summary>
		public int Dequeue()
		{
			if (size == 0)
			{
				throw new NullElementsException("No elements!");
			}
			changingValue = array[0];
			array[0] = array[--size];
			array[size] = changingValue;
			Down(0);
			return array[size];
		}
	}
}