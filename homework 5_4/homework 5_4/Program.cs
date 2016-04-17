namespace ConsoleTravel
{
	public class Program
	{
		static void Main()
		{
			var eventLoop = new EventLoop();
			var consoleTravel = new ConsoleTravel();
			eventLoop.Start += consoleTravel.Start;
			eventLoop.LeftHandler += consoleTravel.Left;
			eventLoop.RightHandler += consoleTravel.Right;
			eventLoop.UpHandler += consoleTravel.Up;
			eventLoop.DownHandler += consoleTravel.Down;
			eventLoop.Begin();
		}
	}
}
