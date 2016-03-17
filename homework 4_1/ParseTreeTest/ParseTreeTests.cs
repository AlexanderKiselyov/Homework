using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ParseTree
{
	[TestClass]
	public class ParsingTreeTests
	{
		[TestMethod]
		public void Example1()
		{
			Assert.AreEqual(18, ParseTree.ParseTreeCounter("(* (+ 4 5) 2)"));
		}

		[TestMethod]
		public void Example2()
		{
			Assert.AreEqual(21, ParseTree.ParseTreeCounter("(* (- (+ (* (/ (+ 1 2) 3) 4) 5) 6) 7)"));
		}

		[TestMethod]
		public void Example3()
		{
			Assert.AreEqual(4, ParseTree.ParseTreeCounter("4"));
		}

		[TestMethod]
		[ExpectedException(typeof(WrongInputException))]
		public void CheckWrongException1()
		{
			ParseTree.ParseTreeCounter("(2");
		}

		[TestMethod]
		[ExpectedException(typeof(ConstructionErrorException))]
		public void CheckWrongException2()
		{
			ParseTree.ParseTreeCounter("(* (7");
		}

		[TestMethod]
		[ExpectedException(typeof(WrongInputException))]
		public void CheckWrongException3()
		{
			ParseTree.ParseTreeCounter("(2t");
		}
	}
}
