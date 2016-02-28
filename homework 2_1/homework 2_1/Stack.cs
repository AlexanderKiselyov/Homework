using System.Collections.Generic;

namespace StackProgram
{
	/// pushes elements into the stack, checks if it is not empty and pull elements out
	public class Stack
	{
		private List<int> list = new List<int>();
	
		/// adds elements to the stack
		public void Push(int number)
		{
			list.Add(number);
		}
	
		/// takes elements off the stack and shows them
		public string Pop()
		{
			if (IsEmpty == true)
			{
				return "No elements.";
			}
			int result = list[list.Count - 1];
			list.RemoveAt(list.Count - 1);
			return result.ToString();
		}
	
		/// checks if the array is empty
		private bool IsEmpty()
		{
			if (list.Count == 0)
			{
				return true;
			}
			return false;
		}
	}
}
