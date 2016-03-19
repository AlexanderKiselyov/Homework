namespace Calculator
{
	/// Adds, Subtracts, Divides and Multiplies two elements.
	public class Calculator
	{
		/// creats Calculator object
		public Calculator(StackInterface stack)
		{
			this.stack = stack;
		}

		private StackInterface stack;

		/// pushes element to stack
		public void Push(int value)
		{
			stack.Push(value);
		}

		/// adds two elements
		public void Add()
		{
			int first = stack.Pop();
			int second = stack.Pop();
			stack.Push(second + first);
		}

		/// subtracts two elements
		public void Subtract()
		{
			int first = stack.Pop();
			int second = stack.Pop();
			stack.Push(second - first);
		}

		/// multiplies two elements
		public void Multiply()
		{
			int first = stack.Pop();
			int second = stack.Pop();
			stack.Push(second * first);
		}

		/// divides two elements
		public void Divide()
		{
			int first = stack.Pop();
			int second = stack.Pop();
			stack.Push(second / first);
		}

		/// returns the result to the stack
		public int Result()
		{
			return stack.Top();
		}
	}
}