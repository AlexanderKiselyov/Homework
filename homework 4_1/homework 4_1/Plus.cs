using System;

namespace Tree
{
	public class Plus : Operations
	{
		public override void Print()
		{
			Console.Write("( + ");
			Left.Print();
			Console.Write(" ");
			Right.Print();
			Console.Write(" ) ");
		}

		public override int Calculation()
		{
			return Right.Calculation() + Left.Calculation();
		}
	}
}
