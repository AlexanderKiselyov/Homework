namespace NewHashTable
{
	/// counts hash function from the element
	public class SecondHash : HashInterface
	{
		/// function that counts hash
		public int Function(int value, int max)
		{
			return value % max;
		}
	}
}
