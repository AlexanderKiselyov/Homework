using System;

namespace ParseTree
{
	/// divide operation
	public class OperationDivide : Operation
	{
		/// divides childrens results and returns it
		override public int Result()
		{
			throwExceptionIfChildrenNull();
			int rightResult = right.Result();
			if (rightResult == 0)
			{
				throw new DivideByZeroException("Divide by zero!");
			}
			return left.Result() / right.Result();
		}

		/// prints itself and its children
		override public void Print()
		{
			throwExceptionIfChildrenNull();
			Console.WriteLine(" /");
			left.Print();
			right.Print();
		}
	}
}
