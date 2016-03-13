using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace NewHashTable.Tests
{
	[TestClass]
	public class HashTableTests
	{
		private HashTable hashTable;

		[TestInitialize]
		public void Initialization()
		{
			hashTable = new HashTable(new FirstHash()); // you can change: "new HashTable(new SecondHash());"
		}

		[TestMethod]
		public void AddAndSearch()
		{
			hashTable.Add(1);
			hashTable.Add(2);
			Assert.AreEqual(true, hashTable.Search(1));
			Assert.AreEqual(true, hashTable.Search(2));
			Assert.AreEqual(false, hashTable.Search(3));
		}

		[TestMethod]
		public void DeleteElement()
		{
			hashTable.DeleteElement(1);
			hashTable.Add(1);
			hashTable.DeleteElement(1);
			Assert.AreEqual(false, hashTable.Search(1));
		}

		[TestMethod]
		[ExpectedException(typeof(ListNullException))]
		public void StandardException()
		{
			ArrayList stack = new ArrayList();
			stack.ReturnValue();
		}
	}
}
