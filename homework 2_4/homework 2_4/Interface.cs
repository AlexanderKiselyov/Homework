namespace Calculator
{
	/// Interface with "Push", "Pop" and "Top" methods.
	public interface StackInterface
	{
		/// adds value to the Stack
		void Push(int value);

		/// returns last element and deletes it
		int Pop();

		/// returns top element
		int Top();
	}
}
