using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Calculator.Test
{
	[TestClass]
	public class CalculatorTests
	{
		Calculator calc;
		StackInterface stack = new List();

		[TestInitialize]
		public void Inizialize()
		{
			calc = new Calculator(stack);
		}

		[TestMethod]
		public void AddTest()
		{
			calc.Push(10);
			calc.Push(5);
			calc.Add();
			Assert.AreEqual(15, calc.Result());
		}

		[TestMethod]
		public void SubtractTest()
		{
			calc.Push(10);
			calc.Push(5);
			calc.Subtract();
			Assert.AreEqual(5, calc.Result());
		}

		[TestMethod]
		public void DivideTest()
		{
			calc.Push(10);
			calc.Push(5);
			calc.Divide();
			Assert.AreEqual(2, calc.Result());
		}

		[TestMethod]
		public void MultiplyTest()
		{
			calc.Push(10);
			calc.Push(5);
			calc.Multiply();
			Assert.AreEqual(50, calc.Result());
		}
	}
}
