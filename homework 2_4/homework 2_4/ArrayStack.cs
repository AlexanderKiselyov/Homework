namespace Calculator
{
	/// can add elements, delete them and return element from the top
	public class ArrayStack : CalculatorInterface
	{
		private static int N = 100;

		private int[] list = new int[N];

		private int pointer = -1;

		/// pushes back current value
		public void Push(int value)
		{
			list[++pointer] = value;
		}

		/// deletes first element and returns its value
		public int Pop()
		{
			int value = 0;
			if (pointer != -1)
			{
				value = list[pointer];
				pointer--;
			}
			return value;
		}

		/// returns first element
		public int Top()
		{
			int value = 0;
			if (pointer != -1)
			{
				value = list[pointer];
			}
			return value;
		}
	}
}
