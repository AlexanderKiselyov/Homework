using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MapFunction.Test
{
	[TestClass]
	public class MapTests
	{
		[TestMethod]
		public void MapTest1()
		{
			Assert.AreEqual(MapFunction.Map(new List<int>() { 1, 2, 3 }, x => x * 2), new List<int>() { 2, 4, 6 });
		}

		[TestMethod]
		public void MapTest2()
		{
			Assert.AreEqual(MapFunction.Map(new List<int>() { 1, 2, 3 }, x => x * x * x), new List<int>() { 1, 8, 27 });
		}

		[TestMethod]
		public void MapTest3()
		{
			Assert.AreEqual(MapFunction.Map(new List<int>() { 1, 2, 3 }, x => x * 0), new List<int>() { 0, 0, 0 });
		}
	}
}
