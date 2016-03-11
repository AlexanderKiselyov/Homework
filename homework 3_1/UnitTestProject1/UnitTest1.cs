using MyStack;

namespace MyStack.Test
{
	using Microsoft.VisualStudio.TestTools.UnitTesting;
	
	//using System.Collections;

	[TestClass]
	public class StackTest
	{
		//private Stack stack;

		[TestInitialize]
		public void Initialize()
		{
			Stack stack = new Stack();
		}

		[TestMethod]
		public void PushTest()
		{
			stack.Push(1);
			//stack.IfEmpty();
			//Assert.IsFalse(stack.IfEmpty());
		}

		[TestMethod]
		public void PopTest()
		{
			stack.Push(2);
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
		public void PopFromEmptyStackTest()
		{
			stack.Pop();
		}
	}
}
