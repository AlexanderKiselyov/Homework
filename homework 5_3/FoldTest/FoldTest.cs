using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace Fold.Test
{
	[TestClass]
	public class FoldTests
	{
		[TestMethod]
		public void FoldTest1()
		{
			Assert.AreEqual(FoldClass.Fold(new List<int>() { 1, 2, 3 }, 1, (acc, elem) => acc * elem), 6);
		}

		[TestMethod]
		public void FoldTest2()
		{
			Assert.AreEqual(FoldClass.Fold(new List<int>() { 0, 5, 6 }, 1, (acc, elem) => acc * elem), 0);
		}
	}
}
