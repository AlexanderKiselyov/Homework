namespace PriorityQueue
{
	public class NewQueueElement
	{
		private PriorityQueue numbers = new PriorityQueue();

		public void Enqueue(int value, int priority)
		{
			numbers.Enqueue(value, priority);
		}

		public int Dequeue()
		{
			return numbers.Dequeue();
		}
	}
}
