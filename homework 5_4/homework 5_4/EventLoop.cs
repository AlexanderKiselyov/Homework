using System;

namespace ConsoleTravel
{
	/// сlass that receives input commands from user and moves cursor or close the program.
	public class EventLoop
	{
		public event EventHandler<EventArgs> Start = (sender, args) => { };
		public event EventHandler<EventArgs> LeftHandler = (sender, args) => { };
		public event EventHandler<EventArgs> RightHandler = (sender, args) => { };
		public event EventHandler<EventArgs> UpHandler = (sender, args) => { };
		public event EventHandler<EventArgs> DownHandler = (sender, args) => { };

		/// converts Right, Left, Up and Down arrows and 'C' into signals
		public void Begin()
		{
			Start(this, EventArgs.Empty);
			while (true)
			{
				var button = Console.ReadKey(true);
				switch (button.Key)
				{
					case ConsoleKey.LeftArrow:
						{
							LeftHandler(this, EventArgs.Empty);
							break;
						}
					case ConsoleKey.RightArrow:
						{
							RightHandler(this, EventArgs.Empty);
							break;
						}
					case ConsoleKey.UpArrow:
						{
							UpHandler(this, EventArgs.Empty);
							break;
						}
					case ConsoleKey.DownArrow:
						{
							DownHandler(this, EventArgs.Empty);
							break;
						}
					case ConsoleKey.C:
						{
							return;
						}
					default:
						{
							break;
						}
				}
			}
		}
	}
}
