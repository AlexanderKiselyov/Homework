using System;
using System.Drawing;
using System.Windows.Forms;

namespace Clock
{
	/// <summary>
	/// shows current date and time
	/// </summary>
	public partial class Clock : Form
	{
		private TableLayoutPanel field;
		private Label label;

		/// <summary>
		/// shows dialogue window and current date and time
		/// </summary>
		public Clock()
		{
			Size = new Size(SystemInformation.VirtualScreen.Width / 3,
										   SystemInformation.VirtualScreen.Height / 3); // устанавливает размеры диалогового окна
			AutoSizeMode = AutoSizeMode.GrowAndShrink; // убирает возможность уменьшать/увеличивать размеры окна
			label = new Label();
			label.Text = DateTime.Now.ToString();
			field = new TableLayoutPanel();
			field.Controls.Add(label);
			Controls.Add(field);
			//BackColor = Color.Green;
			var dateAndTimer = new Timer();
			dateAndTimer.Start();
			dateAndTimer.Tick += ChangeTime;
		}

		/// <summary>
		/// changes time every second
		/// </summary>
		private void ChangeTime(object sender, EventArgs args)
		{
			label.Text = DateTime.Now.ToString();
		}
	}
}
