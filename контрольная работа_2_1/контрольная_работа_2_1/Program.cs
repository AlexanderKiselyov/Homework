using System;

namespace PriorityQueue
{
	class Program
	{
		static void Main(string[] args)
		{
			NewQueueElement numbers = new NewQueueElement();
			numbers.Enqueue(10, 5);
			numbers.Enqueue(8, 4);
			numbers.Dequeue();
			numbers.Dequeue();
			try
			{
				numbers.Dequeue();
			}
			catch(NullElementsException)
			{
				Console.WriteLine("No elements!");
			}
		}
	}
}