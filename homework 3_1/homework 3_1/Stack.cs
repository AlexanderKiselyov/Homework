using System.Collections.Generic;

namespace MyStack
{
	/// Stack can add elements, delete them and check if it is empty.
	public class Stack
	{
		private int count = -1;
		private List<int> list = new List<int>();

		public void Push(int number) // adds elements to the stack
		{
			list.Add(number);
			count++;
		}

		public int Pop() // takes elements off the stack and shows them
		{
			if (count == -1)
			{
				throw new StackNullException("You are trying to pop from an empty stack.");
			}
			int result = list[count];
			count--;
			return result;
		}

		public bool IsEmpty()
		{
			return list.Count == 0;
		}
	}
}
