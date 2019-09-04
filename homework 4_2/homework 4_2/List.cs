using System;

namespace UniqueList
{
	public class List
	{
		public ArrayList list = new ArrayList();

		/// adds elements to the list
		virtual public void Add(int value)
		{
			list.Add(value);
		}

		/// takes elements off the list
		virtual public void DeleteElement(int value)
		{
			list.DeleteElement(value);
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

		/// checks if the elements is in the list
		public bool IfInTheList(int value)
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
