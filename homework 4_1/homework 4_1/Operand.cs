using System;

namespace Tree
{
	// class realising a tree node
	public class Operand : TreeInterface
	{

		public Operand(int value)
		{
			Value = value;
		}

		// value of the operand
		public int Value { set; get; }

		// prints an operand
		public void Print()
		{
			Console.Write((Value - 32) + ' ');
		}

		// returns value of the operand
		public int Calculation()
		{
			return Value;
		}
	}
}
