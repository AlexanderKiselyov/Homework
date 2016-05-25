namespace UniqueList
{
	/// <summary>
	/// class with unique elements
	/// </summary>
	public class UniqueList : List
{
	/// <summary>
	/// adds element to the UniqueList
	/// </summary>
	/// <param name="value"></param>
	override public void Add(int value)
	{
			if (IfInTheList(value))
			{
				throw new TryingToAddExistingElementException("The element is already in the list.");
			}
			else
			{
				list.Add(value);
			}
	}

	/// <summary>
	/// deletes element from the UniqueList
	/// </summary>
	/// <param name="value"></param>
	override public void DeleteElement(int value)
	{
			if (IfInTheList(value))
			{
				list.DeleteElement(value);
			}
			else
			{
				throw new TryingToDeleteNotExistingElementException("There is no this element in the list.");
			}
	}
}
}