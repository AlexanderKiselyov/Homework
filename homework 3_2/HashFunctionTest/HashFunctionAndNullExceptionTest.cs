using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace NewHashTable.Tests
{
	[TestClass]
	public class HashTableTests
	{
		private HashTable hashTable1;
		private HashTable hashTable2;

		[TestInitialize]
		public void Initialization1()
		{
			hashTable1 = new HashTable(new FirstHash());
			hashTable2 = new HashTable(new FirstHash());
		}

		[TestMethod]
		public void AddAndSearch1()
		{
			hashTable1.Add(1);
			hashTable1.Add(2);
			Assert.IsTrue(hashTable1.Search(1));
			Assert.IsTrue(hashTable1.Search(2));
			Assert.IsFalse(hashTable1.Search(3));
		}

		[TestMethod]
		public void DeleteElement1()
		{
			hashTable1.DeleteElement(1);
			hashTable1.Add(1);
			hashTable1.DeleteElement(1);
			Assert.IsFalse(hashTable1.Search(1));
		}

		[TestMethod]
		[ExpectedException(typeof(ListNullException))]
		public void StandardException()
		{
			ArrayList stack = new ArrayList();
			stack.ReturnValue();
		}

		[TestMethod]
		public void AddAndSearch2()
		{
			hashTable2.Add(1);
			hashTable2.Add(2);
			Assert.IsTrue(hashTable2.Search(1));
			Assert.IsTrue(hashTable2.Search(2));
			Assert.IsFalse(hashTable2.Search(3));
		}

		[TestMethod]
		public void DeleteElement2()
		{
			hashTable2.DeleteElement(1);
			hashTable2.Add(1);
			hashTable2.DeleteElement(1);
			Assert.IsFalse(hashTable2.Search(1));
		}
	}
}
