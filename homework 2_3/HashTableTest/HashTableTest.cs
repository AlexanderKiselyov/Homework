namespace NewHashTable.Test
{
	using Microsoft.VisualStudio.TestTools.UnitTesting;

	[TestClass]
	public class HashTableTest
	{
		private HashTable tmp;

		[TestInitialize]
		public void Inizialize()
		{
			tmp = new HashTable();
		}

		[TestMethod]
		public void HashTableTests()
		{
			tmp.Add(100);
			tmp.Add(56);
			tmp.Add(87);
			Assert.AreEqual(true, tmp.Search(87));
			tmp.Add(96);
			tmp.DeleteElement(96);
			Assert.AreEqual(false, tmp.Search(96));
			tmp.Add(11);
		}
	}
}
