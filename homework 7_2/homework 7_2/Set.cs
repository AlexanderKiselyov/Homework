namespace Set
{
	public class Set<T>
	{
		private List<T> set = new List<T>();

		/// adds an element to the set
		public void AddElement(T value)
		{
			set.Push(value);
		}

		/// deletes an element from the set
		public void DeleteElement(T value)
		{
			set.DeleteElement(value);
		}

		/// checks if an element is in the set
		public bool IfInTheList(T value)
		{
			return set.IfInTheList(value);
		}

		/// returns the union of two sets
		public Set<T> UnionOfTwoSets(Set<T> secondSet)
		{
			List<T> unionList = set;
			Set<T> unionSet = new Set<T>();
			foreach (T value in secondSet.GetList())
			{
				if (!unionList.IfInTheList(value))
				{
					unionList.Push(value);
				}
			}
			while (!(unionList.top == null))
			{
				unionSet.AddElement(unionList.Pop());
			}
			return unionSet;
		}

		/// returns the intersection of two sets
		public Set<T> IntersectionOfTwoSets(Set<T> secondSet)
		{
			Set<T> intersectionSet = new Set<T>();
			foreach (T value in secondSet.GetList())
			{
				if (IfInTheList(value))
				{
					intersectionSet.AddElement(value);
				}
			}
			return intersectionSet;
		}

		/// returns this set as list
		public List<T> GetList()
		{
			return set;
		}
	}
}
