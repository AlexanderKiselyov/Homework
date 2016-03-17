using System;

namespace ParseTree
{
	/// multiply operation
	public class OperationMultiply : Operation
	{
		/// multiplies childrens results and returns it
		override public int Result()
		{
			throwExceptionIfChildrenNull();
			return left.Result() * right.Result();
		}

		/// prints itself and its children
		override public void Print()
		{
			throwExceptionIfChildrenNull();
			Console.WriteLine(" *");
			left.Print();
			right.Print();
		}
	}
}