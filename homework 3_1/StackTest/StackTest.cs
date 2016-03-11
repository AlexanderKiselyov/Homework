namespace MyStack.Test
{
	using Microsoft.VisualStudio.TestTools.UnitTesting;

	[TestClass]
	public class StackTest
	{
		private Stack stack;

		[TestInitialize]
		public void Initialize()
		{
			stack = new Stack();
		}

		[TestMethod]
		public void PushTest()
		{
			stack.Push(1);
			Assert.IsFalse(stack.IsEmpty());
		}

		[TestMethod]
		public void PopTest()
		{
			stack.Push(1);
			Assert.AreEqual(1, stack.Pop());
		}

		[TestMethod]
		public void TwoElementsPopTest()
		{
			stack.Push(1);
			stack.Push(2);
			Assert.AreEqual(2, stack.Pop());
			Assert.AreEqual(1, stack.Pop());
		}

		[TestMethod]
		[ExpectedException(typeof(StackNullException))]
		public void PopFromEmptyStackTest()
		{
			stack.Pop();
		}
	}
}

