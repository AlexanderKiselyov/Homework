namespace ParseTree
{
	/// can get and return its value and print itself
	public abstract class Operation : InterfaceParseTreeVertex
	{
		protected InterfaceParseTreeVertex left = null;
		protected InterfaceParseTreeVertex right = null;

		/// sets left child
		public void SetLeft(InterfaceParseTreeVertex left)
		{
			this.left = left;
		}

		/// sets right child
		public void SetRight(InterfaceParseTreeVertex right)
		{
			this.right = right;
		}

		protected void throwExceptionIfChildrenNull()
		{
			if (left == null || right == null)
			{
				throw new NullException();
			}
		}

		/// abstract method of getting result
		abstract public int Result();

		/// abstract method of printing itself
		abstract public void Print();
	}
}