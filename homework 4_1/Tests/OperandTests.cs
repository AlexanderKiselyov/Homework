using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ParseTree
{
	[TestClass]
	public class OperandTest
	{
		private Operand operand;

		[TestInitialize]
		public void Initialize()
		{
			operand = new Operand();
		}

		[TestMethod]
		public void ConstructorTest()
		{
			operand = new Operand(18);
			Assert.AreEqual(18, operand.Result());
		}
	}
}
