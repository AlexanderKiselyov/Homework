using System;

namespace StackProgram
{
	/// test of the stack
	class Program
	{
		static void Main(string[] args)
		{
			Stack stack = new Stack();
			stack.Push(10);
			stack.Push(7);
			stack.Push(2);
			Console.WriteLine(stack.Pop());
			Console.WriteLine(stack.Pop());
			Console.WriteLine(stack.Pop());
		}
	}
}
