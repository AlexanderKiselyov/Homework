using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ListAndStack.Test
{
	[TestClass]
	public class Test
	{
		private List<int> list;

		[TestInitialize]
		public void Initialise()
		{
			list = new List<int>();
		}

		[TestMethod]
		public void PopTest()
		{
			list.Push(3);
			Assert.AreEqual(3, list.Pop());
		}

		[TestMethod]
		[ExpectedException(typeof(NullElementsException))]
		public void PopFromTheEmptyListTest()
		{
			list.Pop();
		}

		[TestMethod]
		public void TwoElementsPopTest()
		{
			list.Push(1);
			list.Push(2);
			Assert.AreEqual(2, list.Pop());
			Assert.AreEqual(1, list.Pop());
		}

		[TestMethod]
		public void DeleteElementTest()
		{
			list.Push(1);
			list.Push(2);
			list.Push(3);
			list.Push(4);
			list.DeleteElement(2);
			Assert.IsFalse(list.IfInTheList(2));
			list.DeleteElement(3);
			Assert.IsFalse(list.IfInTheList(3));
		}

		[TestMethod]
		public void IfInTheListTest()
		{
			list.Push(10);
			list.Push(17);
			list.Push(5);
			Assert.IsTrue(list.IfInTheList(10));
			Assert.IsTrue(list.IfInTheList(17));
			Assert.IsTrue(list.IfInTheList(5));
		}

		[TestMethod]
		public void NumberOfElementsTest()
		{
			list.Push(4);
			list.Push(3);
			list.Push(8);
			Assert.AreEqual(3, list.counter);
		}

		[TestMethod]
		public void DeleteFromThePositoinTest()
		{
			list.Push(1);
			list.Push(2);
			list.Push(3);
			list.Push(4);
			list.DeleteFromThePosition(3);
			list.DeleteFromThePosition(1);
			Assert.IsFalse(list.IfInTheList(1));
			Assert.IsFalse(list.IfInTheList(3));
		}

		[TestMethod]
		public void AddToAPositionTest()
		{
			list.Push(1);
			list.Push(2);
			list.Push(3);
			list.AddToAPosition(5, 1);
			list.Pop();
			Assert.AreEqual(5, list.Pop());
		}
	}
}
