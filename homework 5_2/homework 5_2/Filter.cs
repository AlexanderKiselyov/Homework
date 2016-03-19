using System;
using System.Collections.Generic;

namespace Filter
{
	/// class that can check if the element with the quality from the function is in the list
	public static class FilterFunction
	{
		/// returns elements with true meaning from the function
		static public List<int> Filter(List<int> list, Func<int, bool> function)
		{
			List<int> result = new List<int>();
			for (int i = 0; i < list.Count; i++)
			{
				if (function(list[i]))
				{
					result.Add(list[i]);
				}
			}
			return result;
		}
	}
}
