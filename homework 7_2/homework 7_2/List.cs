using System;
using System.Collections;

namespace Set
{
	/// class that can add elements to the collection, delete them and show
	public class List<T> : IEnumerable
	{
		public ListElement top;
		public int elementsCounter = 0;

		/// class that describes elements of the list
		public class ListElement
		{
			public T Value { get; set; }
			public ListElement Next { get; set; }

			public ListElement(T value, ListElement nextElement)
			{
				Value = value;
				Next = nextElement;
			}
		}

		/// adds element to the end of the list
		public void Push(T value)
		{
			ListElement newElement = new ListElement(value, top);
			newElement.Next = top;
			top = newElement;
			elementsCounter++;
		}

		/// adds element to a position in the list
		public void AddToAPosition(T value, int position)
		{
			if (position > elementsCounter)
			{
				position = elementsCounter + 1;
			}
			if (position <= 0)
			{
				Push(value);
			}
			else
			{
				var current = top;
				for (int i = 1; i < position; ++i)
				{
					current = current.Next;
				}
				var newListElement = new ListElement(value, current.Next);
				current.Next = newListElement;
			}
			elementsCounter++;
		}

		/// deletes element from the top of the list
		public T Pop()
		{
			if (top == null)
			{
				throw new NullElementsException("List is empty.");
			}
			else
			{
				T value = top.Value;
				top = top.Next;
				elementsCounter--;
				return value;
			}
		}

		/// prints elements from the list
		public void Print()
		{
			ListElement current = top;
			while (current != null)
			{
				Console.WriteLine(current.Value);
				current = current.Next;
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
			ListElement current = top;
			if (current.Value.Equals(value))
			{
				top = current.Next;
				elementsCounter--;
				return;
			}
			while (current.Next != null)
			{
				if (current.Next.Value.Equals(value))
				{
					current.Next = current.Next.Next;
					elementsCounter--;
					return;
				}
				current = current.Next;
			}
		}

		/// removes an element from position int the list
		public void DeleteFromThePosition(int position)
		{
			if (position >= elementsCounter)
			{
				position = elementsCounter - 1;
			}
			if (position == 0)
			{
				Pop();
				elementsCounter--;
				return;
			}
			var current = top;
			for (int i = 1; i < position; ++i)
			{
				current = current.Next;
			}
			current.Next = current.Next.Next;
			elementsCounter--;
			return;
		}

		/// checks if element is in the list
		public bool IfInTheList(T value)
		{
			ListElement current = top;
			while (current != null)
			{
				if (current.Value.Equals(value))
				{
					break;
				}
				current = current.Next;
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
				current = current == null ? list.top : current.Next;
				return position < list.elementsCounter;
			}

			/// returns the enumerator to the position before the first element
			public void Reset()
			{
				position = -1;
				current = null;
			}

			object IEnumerator.Current
			{
				get { return Current; }
			}

			/// returns a value of the current element of list
			public T Current
			{
				get
				{
					try
					{
						return current.Value;
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
