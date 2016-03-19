using System;
using System.Collections.Generic;

namespace MapFunction
{
	/// class that can change input elements with the help of the function
	public class MapFunction
	{
		/// takes an element and returns the result of the function from it
		static public List<int> Map(List<int> list, Func<int, int> function)
		{
			List<int> result = new List<int>();
			for (int i = 0; i < list.Count; i++)
			{
				result.Add(function(list[i]));
			}
			return result;
		}
	}
}
