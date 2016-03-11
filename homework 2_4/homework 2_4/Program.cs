using System;

namespace Calculator
{
	class ConsoleMain
	{
		public static void Main()
		{
			Interface stack;
			Console.WriteLine("Type:\n 2 to use Stack on references;\n 1 to use List as a Stack;\n 0 to use Stack on an Array.\n");
			int command = Convert.ToUInt16(Console.ReadLine());
			while ((command > 2) || (command < 0))
			{
				Console.WriteLine("Wrong input.");
				command = Convert.ToUInt16(Console.ReadLine());
			}
			if (command == 2)
			{
				stack = new ReferenceStack();
			}
			else if (command == 1)
			{
				stack = new List();
			}
			else
			{
				stack = new ArrayStack();
			}

			Calculator calc = new Calculator(stack);

			calc.Push(3);
			calc.Push(7);
			calc.Add();
			calc.Push(8);
			calc.Push(2);
			calc.Add();
			calc.Multiply();
			calc.Push(5);
			calc.Divide();
			Console.WriteLine("The result of classic expression is {0}.", calc.Result());
		}
	}
}