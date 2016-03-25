namespace PriorityQueue
{
	public class NewQueueElement
	{
		private PriorityQueue numbers = new PriorityQueue();

		public void enqueue(int value, int priority)
		{
			numbers.enqueue(value, priority);
		}

		public void dequeue()
		{
			numbers.dequeue();
		}
	}
}
