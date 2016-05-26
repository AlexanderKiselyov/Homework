namespace Tree
{
	// class that operats with operations and tree nodes
	public class Operations : TreeInterface
	{
		public TreeInterface Left { set; get; }
		public TreeInterface Right { set; get; }

		// prints expression
		public virtual void Print()
		{
		}

		// calculates expression
		public virtual int Calculation()
		{
			return 0;
		}
	}
}
