namespace ParseTree
{
	/// contains Operation values, allows to push values into itself, to remove last element, returning its value, to get last element's value
	public class ParseStack
	{
		private ParseStackElement head = null;

		/// gets value and sets element with current value as head
		public void Push(Operation value)
		{
			head = new ParseStackElement(value, head);
		}

		/// Deletes last element, returns its value. If stack is empty, throws exception.
		public ParseStackElement Pop()
		{
			if (head == null)
			{
				throw new NullStackException("Trying to pop an empty stack.");
			}
			ParseStackElement result = head;
			head = head.GetNext();
			return result;
		}
		/// returns last element itself, throws exception if empty
		public ParseStackElement Top()
		{
			if (head == null)
			{
				throw new NullStackException("Trying to top an empty stack.");
			}
			return head;
		}
	}
}
