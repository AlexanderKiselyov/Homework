using System;

namespace MyStack
{
	class Program
	{
		static void Main(string[] args)
		{
			Stack stack = new Stack();
			stack.Push(1);
			stack.Push(2);
			stack.Push(3);
			Console.WriteLine(stack.Pop());
			Console.WriteLine(stack.Pop());
			Console.WriteLine(stack.Pop());
			try
			{
				stack.Pop();
			}
			catch (StackNullException e)
			{
				Console.WriteLine("{0}", e.Message);
			}
		}
	}
}
