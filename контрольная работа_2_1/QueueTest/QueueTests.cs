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
			numbers.enqueue(5, 10);
			numbers.enqueue(8, 3);
			numbers.enqueue(7, 67);
			numbers.dequeue();
			numbers.dequeue();
			numbers.dequeue();
			Assert.AreEqual(new NewQueueElement(), numbers);
		}

		[TestMethod]
		[ExpectedException(typeof(NullElementsException))]
		public void NullElements()
		{
			numbers.dequeue();
		}

		[TestMethod]
		[ExpectedException(typeof(OverloadException))]
		public void Overload()
		{
			for (int i = 0; i < 105; i++)
			{
				numbers.enqueue(10, i);
			}
		}
	}
}

