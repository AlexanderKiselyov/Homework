using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Filter.Test
{
	[TestClass]
	public class FilterTests
	{
		[TestMethod]
		public void FilterTest1()
		{
			Assert.AreEqual(FilterFunction.Filter(new List<int>() { 1, 2, 3 }, x => { return x % 3 == 0; }), new List<int>() { 3 });
		}

		[TestMethod]
		public void FilterTest2()
		{
			Assert.AreEqual(FilterFunction.Filter(new List<int>() { 1, 2, 8 }, x => { return x <= 5; }), new List<int>() { 1, 2 });
		}
	}
}
