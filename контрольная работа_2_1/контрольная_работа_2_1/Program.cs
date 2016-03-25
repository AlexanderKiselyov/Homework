namespace PriorityQueue
{
	class Program
	{
		static void Main(string[] args)
		{
			NewQueueElement numbers = new NewQueueElement();
			numbers.enqueue(10, 5);
			numbers.enqueue(8, 4);
			numbers.dequeue();
			numbers.dequeue();
		}
	}
}