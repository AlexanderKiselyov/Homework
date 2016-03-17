namespace ParseTree
{
	/// standart element for stack with Operation as a value type
	public class ParseStackElement
	{
		public ParseStackElement(Operation value = null, ParseStackElement next = null)
		{
			this.value = value;
			this.next = next;
		}

		private int count = 0;
		private Operation value;
		private ParseStackElement next;

		public void IncreaseCount()
		{
			count++;
		}

		public int GetCount()
		{
			return count;
		}

		public Operation GetValue()
		{
			return value;
		}

		public ParseStackElement GetNext()
		{
			return next;
		}
	}
}