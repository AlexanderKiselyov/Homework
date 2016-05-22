using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Set
{
	[TestClass]
	public class Test
	{
		private Set<int> set;

		[TestInitialize]
		public void Initialization()
		{
			set = new Set<int>();
		}

		[TestMethod]
		public void AddElementTest()
		{
			set.AddElement(1);
			Assert.IsTrue(set.IfInTheList(1));
		}

		[TestMethod]
		public void DeleteElementTest()
		{
			set.AddElement(1);
			set.AddElement(8);
			set.DeleteElement(8);
			Assert.IsFalse(set.IfInTheList(8));
			set.DeleteElement(1);
			Assert.IsFalse(set.IfInTheList(1));
		}

		[TestMethod]
		public void UnionOfTwoSetsTest()
		{
			set.AddElement(1);
			set.AddElement(2);
			set.AddElement(3);
			var newSet = new Set<int>();
			newSet.AddElement(9);
			newSet.AddElement(7);
			newSet.AddElement(1);
			newSet = set.UnionOfTwoSets(newSet);
			Assert.IsTrue(newSet.IfInTheList(1));
			Assert.IsTrue(newSet.IfInTheList(2));
			Assert.IsTrue(newSet.IfInTheList(3));
			Assert.IsTrue(newSet.IfInTheList(9));
			Assert.IsTrue(newSet.IfInTheList(7));
		}

		[TestMethod]
		public void IntersectionOfTwoSetsTest()
		{
			set.AddElement(1);
			set.AddElement(2);
			set.AddElement(3);
			var newSet = new Set<int>();
			newSet.AddElement(3);
			newSet.AddElement(14);
			newSet.AddElement(10);
			newSet = set.IntersectionOfTwoSets(newSet);
			Assert.IsTrue(newSet.IfInTheList(3));
			Assert.IsFalse(newSet.IfInTheList(10));
		}
	}
}
