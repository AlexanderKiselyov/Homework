using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace PriorityQueue.Tests
{
	[TestClass]
	public class QueueTests
	{
		private NewQueueElement numbers;

		[TestInitialize]
		public void Initialization()
		{
			numbers = new NewQueueElement();
		}

		[TestMethod]
		public void AddAndDeleteTest()
		{
			numbers.Enqueue(5, 10);
			numbers.Enqueue(8, 3);
			numbers.Enqueue(7, 67);
			Assert.AreEqual(numbers.Dequeue(), 7);
			Assert.AreEqual(numbers.Dequeue(), 5);
			Assert.AreEqual(numbers.Dequeue(), 8);
		}

		[TestMethod]
		[ExpectedException(typeof(NullElementsException))]
		public void NullElements()
		{
			numbers.Dequeue();
		}

		[TestMethod]
		[ExpectedException(typeof(OverloadException))]
		public void Overload()
		{
			for (int i = 0; i < 105; i++)
			{
				numbers.Enqueue(10, i);
			}
		}
	}
}

