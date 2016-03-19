namespace Calculator
{
	/// can add elements, delete them and return element from the top
	public class ReferenceStack : CalculatorInterface
	{
		class ReferenceStackElement
		{
			private int value = 0;
			private ReferenceStackElement next = null;

			public ReferenceStackElement(int value = 0, ReferenceStackElement next = null)
			{
				this.value = value;
				this.next = next;
			}

			/// returns value
			public int GetValue()
			{
				return value;
			}

			/// returns next element
			public ReferenceStackElement GetNext()
			{
				return next;
			}
		}

		private ReferenceStackElement Last = null;

		/// pushes element to the end
		public void Push(int value)
		{
			Last = new ReferenceStackElement(value, Last);
		}

		/// sets next element from the last element
		public int Pop()
		{
			if (Last == null)
			{
				return 0;
			}
			int result = Last.GetValue();
			Last = Last.GetNext();
			return result;
		}

		/// returns value of the last element
		public int Top()
		{
			if (Last == null)
			{
				return 0;
			}
			return Last.GetValue();
		}
	}
}