using System;

namespace Tree
{
	public class Divide : Operations
	{
		public override void Print()
		{
			Console.Write("( / ");
			Left.Print();
			Console.Write(" ");
			Right.Print();
			Console.Write(" ) ");
		}

		public override int Calculation()
		{
			if (Right.Calculation() == 0)
			{
				throw new Exception("Division by 0.");
			}
			return Left.Calculation() / Right.Calculation();
		}
	}
}

