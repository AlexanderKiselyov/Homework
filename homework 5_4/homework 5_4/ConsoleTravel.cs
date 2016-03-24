using System;

namespace ConsoleTravel
{
	/// class that receives signals from EventLoop and move cursor up, down, left or right
	public class ConsoleTravel
	{
		private Coordinates max = new Coordinates();
		private int x = 79; // length of the travel field
		private int y = 24; // height of the travel field

		public void Start(object sender, EventArgs args)
		{
			Console.CursorTop = 0;
			for (int i = 0; i < y; i++)
			{
				Console.WriteLine();
			}
			Console.WriteLine("Type 'C' to close the program.");
			max = new Coordinates(x, Console.CursorTop - 1);
			Console.CursorTop -= y + 1;
		}

		/// moves cursor left, if possible
		public void Left(object sender, EventArgs args)
		{
			try
			{
				Console.CursorLeft--;
			}
			catch (ArgumentOutOfRangeException)
			{
			}
		}

		/// moves cursor right, if possible
		public void Right(object sender, EventArgs args)
		{
			if (Console.CursorLeft != max.X)
			{
				Console.CursorLeft++;
			}
		}

		/// moves cursor up, if possible
		public void Up(object sender, EventArgs args)
		{
			if (Console.CursorTop != max.Y - y)
			{
				Console.CursorTop--;
			}
		}

		/// moves cursor down, if possible
		public void Down(object sender, EventArgs args)
		{
			if (Console.CursorTop != max.Y)
			{
				Console.CursorTop++;
			}
		}
	}
}