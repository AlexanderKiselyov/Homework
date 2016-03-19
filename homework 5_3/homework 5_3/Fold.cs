using System;
using System.Collections.Generic;

namespace Fold
{
	/// class that outputs result converting each element from the list
	public static class FoldClass
	{
		/// with the help of the function changes result according to each element in the list
		static public int Fold(List<int> list, int first,
											Func<int, int, int> function)
		{
			int result = first;
			for (int i = 0; i < list.Count; i++)
			{
				result = function(result, list[i]);
			}
			return result;
		}
	}
}