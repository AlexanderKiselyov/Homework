using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ListAndStack.Test
{
	[TestClass]
	public class StackTest
	{
		private Stack<string> stack;

		[TestInitialize]
		public void Inizialize()
		{
			stack = new Stack<string>();
		}

		[TestMethod]
		public void PushAndPopTest()
		{
			stack.Push("123");
			stack.Push("12345");
			Assert.AreEqual("12345", stack.Pop());
		}
	}
}