using System.Collections.Generic;

namespace Calculator
{
	/// <summary>
	/// can add elements to the stack, pop them and delete all the elements
	/// </summary>
	public class Stack
	{
		public static Stack<int> stack = new Stack<int>();

		/// adds elements to the stack
		public static void Push(int number)
		{
			stack.Push(number);
		}

		/// takes elements off the stack and shows them
		public static int Pop()
		{
			return stack.Pop();
		}

		/// deletes all the element from stack
		public static void Clear()
		{
			stack.Clear();
		}
	}
}