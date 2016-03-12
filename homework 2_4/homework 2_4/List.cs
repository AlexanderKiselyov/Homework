using System;

namespace Calculator
{
	public class List : CalculatorInterface
	{
		private ListElement list = new ListElement();

		/// adds elements to the list
		public void Push(int value)
		{
			list.Add(value);
		}

		/// takes elements off the list
		public void DeleteElement(int value)
		{
			list.SetIteratorFirst();
			while (!list.IfIteratorNull() && list.ReturnValue() != value)
			{
				list.MoveIterator();
			}
			if (!list.IfIteratorNull())
			{
				list.DeleteElement();
			}
		}

		/// shows all the elements from the list
		public void Show()
		{
			list.SetIteratorFirst();
			while (!list.IfIteratorNull())
			{
				Console.Write(list.ReturnValue());
				Console.Write(' ');
				list.MoveIterator();
			}
			Console.WriteLine();
			list.SetIteratorFirst();
		}

		///  returns the first element and deletes it
		public int Pop()
		{
			list.SetIteratorLast();
			int value = list.ReturnValue();
			list.DeleteElement();
			return value;
		}

		/// returns value of the last element
		public int Top()
		{
			list.SetIteratorLast();
			return list.ReturnValue();
		}

		/// checks if the elements is in the list
		public bool Search(int value)
		{
			list.SetIteratorFirst();
			while (!list.IfIteratorNull())
			{
				if (list.ReturnValue() == value)
				{
					list.SetIteratorFirst();
					return true;
				}
				list.MoveIterator();
			}
			list.SetIteratorFirst();
			return false;
		}
	}
}
