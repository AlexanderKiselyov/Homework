using System;
using System.Windows.Forms;

namespace Clock
{
	public class Program
	{
		/// <summary>
		/// Главная точка входа для приложения.
		/// </summary>
		[STAThread]
		public static void Main()
		{
			Application.Run(new Clock());
		}
	}
}
