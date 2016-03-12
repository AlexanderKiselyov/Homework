﻿using System;

namespace HashTable
{
	class List
	{
		private ListElement list = new ListElement();

		/// adds elements to the list
		public void Add(int value)
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