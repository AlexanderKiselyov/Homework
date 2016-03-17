using System;

namespace ParseTree
{
	/// class that contains integer value and its return method
	public class Operand : InterfaceParseTreeVertex
	{
		private int value;

		public Operand(int value = 0)
		{
			this.value = value;
		}

		virtual public int Result()
		{
			return value;
		}

		virtual public void Print()
		{
			Console.Write(" {0}", value);
		}
	}
}
