using System;

namespace ListAndStack
{
	/// <summary>
	/// stack class that can add elements, delete them and print all of them
	/// </summary>
	public class Stack<T>
	{
		private Element head = new Element();
		private int counter;

		class Element
		{
			private T value;
			private Element next;

			public T Value
			{
				get
				{
					return value;
				}
				set
				{
					this.value = value;
				}
			}

			public Element Next
			{
				get
				{
					return next;
				}
				set
				{
					next = value;
				}
			}
		}

		public Stack()
		{
			counter = 0;
		}

		/// <summary>
		/// add element in stack
		/// </summary>
		/// <param name="value"></param>
		public void Push(T value)
		{
			if (counter == 0)
			{
				head.Value = value;
			}
			else
			{
				Element temp = new Element();
				temp.Value = value;
				temp.Next = head;
				head = temp;
			}
			counter++;
		}

		/// <summary>
		/// deletes first element from the stack
		/// </summary>
		public T Pop()
		{
			if (head == null)
			{
				throw new NullElementsException("Stack is empty.");
			}
			else
			{
				T temp = head.Value;
				head = head.Next;
				return temp;
			}
		}

		/// <summary>
		/// prints all stack
		/// </summary>
		public void Print()
		{
			Element temp = head;
			for (int i = 0; i <= counter; i++)
			{
				Console.WriteLine(temp.Value);
				temp = temp.Next;
			}
		}
	}
}