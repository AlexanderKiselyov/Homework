using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ParseTree
{
	[TestClass]
	public class ParseStackTest
	{
		private ParseStack stack;

		[TestInitialize]
		public void Initialization()
		{
			stack = new ParseStack();
		}

		[TestMethod]
		public void PushAndPop()
		{
			Operation operation1 = new OperationAdd();
			operation1.SetLeft(new Operand(5));
			operation1.SetRight(new Operand(4));
			Operation operation2 = new OperationSubtract();
			operation2.SetLeft(new Operand(3));
			operation2.SetRight(new Operand(2));
			stack.Push(operation1);
			stack.Push(operation2);
			Assert.AreEqual(1, stack.Pop().GetValue().Result());
			Assert.AreEqual(9, stack.Pop().GetValue().Result());
		}

		[TestMethod]
		[ExpectedException(typeof(NullStackException))]
		public void StandardException()
		{
			stack.Pop();
		}
	}
}