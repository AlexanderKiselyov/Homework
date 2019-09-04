using System;
using System.Collections;

namespace ListAndStack
{
	/// class that can add elements to the collection, delete them and show
	public class List<T> : IEnumerable
	{
		private ListElement head;
		public int counter = 0;

		/// class that describes elements of the list
		private class ListElement
		{
			public T value { get; set; }
			public ListElement next { get; set; }

			public ListElement(T value, ListElement nextElement)
			{
				this.value = value;
				next = nextElement;
			}
		}

		/// adds element to the end of the list
		public void Push(T value)
		{
			ListElement newElement = new ListElement(value, head);
			newElement.next = head;
			head = newElement;
			counter++;
		}

		/// adds element to a position in the list
		public void AddToAPosition(T value, int position)
		{
			if (position > counter)
			{
				position = counter + 1;
			}
			if (position <= 0)
			{
				Push(value);
			}
			else
			{
				var current = head;
				for (int i = 1; i < position; ++i)
				{
					current = current.next;
				}
				var newListElement = new ListElement(value, current.next);
				current.next = newListElement;
			}
			counter++;
		}

		/// deletes element from the top of the list
		public T Pop()
		{
			if (head == null)
			{
				throw new NullElementsException("List is empty.");
			}
			else
			{
				T value = head.value;
				head = head.next;
				counter--;
				return value;
			}
		}

		/// prints elements from the list
		public void Print()
		{
			ListElement current = head;
			while (current != null)
			{
				Console.WriteLine(current.value);
				current = current.next;
			}
		}

		/// deletes element from the list
		public void DeleteElement(T value)
		{
			if (IfInTheList(value) == false)
			{
				Console.WriteLine("There is no element '{0}' in the list.", value);
				return;
			}
			ListElement current = head;
			if (current.value.Equals(value))
			{
				head = current.next;
				counter--;
				return;
			}
			while (current.next != null)
			{
				if (current.next.value.Equals(value))
				{
					current.next = current.next.next;
					counter--;
					return;
				}
				current = current.next;
			}
		}

		/// removes an element from position in the list
		public void DeleteFromThePosition(int position)
		{
			if (position >= counter)
			{
				position = counter - 1;
			}
			if (position == 0)
			{
				Pop();
				counter--;
				return;
			}
			var current = head;
			for (int i = 1; i < position; ++i)
			{
				current = current.next;
			}
			current.next = current.next.next;
			counter--;
			return;
		}

		/// checks if element is in the list
		public bool IfInTheList(T value)
		{
			ListElement current = head;
			while (current != null)
			{
				if (current.value.Equals(value))
				{
					break;
				}
				current = current.next;
			}
			return current != null;
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return GetEnumerator();
		}

		public ListEnumerator GetEnumerator()
		{
			return new ListEnumerator(this);
		}

		public class ListEnumerator : IEnumerator
		{
			private List<T> list;
			private int position = -1;
			private ListElement current;

			public ListEnumerator(List<T> newList)
			{
				list = newList;
				current = null;
			}

			/// moves to the next list element
			public bool MoveNext()
			{
				position++;
				current = current == null ? list.head : current.next;
				return position < list.counter;
			}

			/// returns the enumerator to the position before the first element
			public void Reset()
			{
				position = -1;
				current = null;
			}

			object IEnumerator.Current
			{
				get
				{
					return Current;
				}
			}

			/// returns a value of the current element of list
			public T Current
			{
				get
				{
					try
					{
						return current.value;
					}
					catch (IndexOutOfRangeException)
					{
						throw new InvalidOperationException();
					}
				}
			}
		}
	}
}