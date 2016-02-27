using System.Collections.Generic;

/// pushes elements into the stack and pull them out
public class Stack
{
	private List<int> list = new List<int>();
	
	/// adds elements to the stack
	public void Push(int number)
	{
		list.Add(number);
	}
	
	/// takes elements off the stack and shows them
	public int Pop()
	{
		if (list.Count == 0)
		{
			return 0;
		}
		int result = list[list.Count - 1];
		list.RemoveAt(list.Count - 1);
		return result;
	}
}
