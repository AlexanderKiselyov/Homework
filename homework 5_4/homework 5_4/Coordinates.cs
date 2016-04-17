namespace ConsoleTravel
{
	/// class that can get and set coordinates
	public class Coordinates
	{
		public int X { get; set; }
		public int Y { get; set; }

		public Coordinates(int X = 0, int Y = 0)
		{
			this.X = X;
			this.Y = Y;
		}
	}
}
