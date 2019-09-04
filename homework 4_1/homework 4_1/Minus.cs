using System;

namespace Tree
{
	public class Minus : Operations
	{
		public override void Print()
		{
			Console.Write("( - ");
			Left.Print();
			Console.Write(" ");
			Right.Print();
			Console.Write(" ) ");
		}

		public override int Calculation()
		{
			return Left.Calculation() - Right.Calculation();
		}
	}
}
