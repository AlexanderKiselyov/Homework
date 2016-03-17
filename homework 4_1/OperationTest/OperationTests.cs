using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ParseTree
{
	[TestClass]
	public class OperationTest
	{
		private Operation operation;

		[TestMethod]
		public void AddTest()
		{
			operation = new OperationAdd();
			operation.SetRight(new Operand(14));
			operation.SetLeft(new Operand(3));
			Assert.AreEqual(17, operation.Result());
		}

		[TestMethod]
		public void SubtractTest1()
		{
			operation = new OperationSubtract();
			operation.SetRight(new Operand(4));
			operation.SetLeft(new Operand(8));
			Assert.AreEqual(4, operation.Result());
		}

		[TestMethod]
		public void SubtractTest2()
		{
			operation = new OperationSubtract();
			operation.SetRight(new Operand(8));
			operation.SetLeft(new Operand(4));
			Assert.AreEqual(-4, operation.Result());
		}

		[TestMethod]
		public void MultiplyTest1()
		{
			operation = new OperationMultiply();
			operation.SetRight(new Operand(3));
			operation.SetLeft(new Operand(7));
			Assert.AreEqual(21, operation.Result());
		}

		[TestMethod]
		public void MultiplyTest2()
		{
			operation = new OperationMultiply();
			operation.SetRight(new Operand(0));
			operation.SetLeft(new Operand(17));
			Assert.AreEqual(0, operation.Result());
		}

		[TestMethod]
		public void DivideTest1()
		{
			operation = new OperationDivide();
			operation.SetRight(new Operand(7));
			operation.SetLeft(new Operand(7));
			Assert.AreEqual(1, operation.Result());
		}

		[TestMethod]
		[ExpectedException(typeof(DivideByZeroException))]
		public void DivideTest2()
		{
			operation = new OperationDivide();
			operation.SetRight(new Operand(0));
			operation.SetLeft(new Operand(10));
			Assert.AreEqual(0, operation.Result());
		}

		[TestMethod]
		public void DivideTest3()
		{
			operation = new OperationDivide();
			operation.SetRight(new Operand(19));
			operation.SetLeft(new Operand(0));
			Assert.AreEqual(0, operation.Result());
		}

		[TestMethod]
		[ExpectedException(typeof(NullException))]
		public void NullTest1()
		{
			operation = new OperationAdd();
			operation.SetLeft(new Operand(17));
			Assert.AreEqual(17, operation.Result());
		}

		[TestMethod]
		[ExpectedException(typeof(NullException))]
		public void NullTest2()
		{
			operation = new OperationAdd();
			operation.SetLeft(new Operand(19));
			operation.Print();
		}
	}
}
