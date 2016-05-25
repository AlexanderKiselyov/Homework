using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UniqueList.Test
{
	[TestClass]
	public class UniqueListTest
	{
		private UniqueList list;

		[TestInitialize]
		public void Inizialize()
		{
			list = new UniqueList();
		}

		[TestMethod]
		public void AddAndDeleteTest()
		{
			list.Add(5);
			list.Add(10);
			list.DeleteElement(10);
			list.Add(30);
			list.DeleteElement(5);
		}

		[TestMethod]
		[ExpectedException(typeof(TryingToAddExistingElementException))]
		public void AddExistingElementExceptionTest()
		{
			list.Add(10);
			list.Add(10);
		}

		[TestMethod]
		[ExpectedException(typeof(TryingToDeleteNotExistingElementException))]
		public void DeleteNotExistingElementExceptionTest()
		{
			list.DeleteElement(11);
		}
	}
}