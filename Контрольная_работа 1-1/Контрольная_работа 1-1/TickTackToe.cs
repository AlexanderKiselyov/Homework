using System;
using System.Windows.Forms;

namespace Контрольная_работа_1_1
{
	/// TickTackToe game
	public partial class TickTackToe : Form
	{
		private int currentMove = 1;

		public TickTackToe()
		{
			InitializeComponent();
			AutoSizeMode = AutoSizeMode.GrowAndShrink; // убирает возможность уменьшать/увеличивать размеры окна
		}

		/// <summary>
		/// checks if the first player(X) moves or the second(O)
		/// </summary>
		/// <returns></returns>
		private bool IfFirstPlayer()
		{
			int newCurrentMove = currentMove;
			currentMove++;
			if ((newCurrentMove % 2) == 1)
			{
				return true;
			}
			else
			{
				return false;
			}
		}

		private void button1_Click(object sender, EventArgs e)
		{
			if (button10.Text == "X wins." || button10.Text == "O wins.")
			{
				button1.Enabled = false;
			}
			else
			{
				if (IfFirstPlayer() == true)
				{
					button1.Text = "X";
				}
				else
				{
					button1.Text = "O";
				}
				if (button1.Text == "X")
				{
					if ((button1.Text == button4.Text) && (button1.Text == button7.Text))
					{
						button10.Text = "X wins.";
						button10.Enabled = false;
					}
					if ((button1.Text == button2.Text) && (button1.Text == button3.Text))
					{
						button10.Text = "X wins.";
						button10.Enabled = false;
					}
					if ((button1.Text == button5.Text) && (button1.Text == button9.Text))
					{
						button10.Text = "X wins.";
						button10.Enabled = false;
					}
				}
				else
				{
					if ((button1.Text == button4.Text) && (button1.Text == button7.Text))
					{
						button10.Text = "O wins.";
						button10.Enabled = false;
					}
					if ((button1.Text == button2.Text) && (button1.Text == button3.Text))
					{
						button10.Text = "O wins.";
						button10.Enabled = false;
					}
					if ((button1.Text == button5.Text) && (button1.Text == button9.Text))
					{
						button10.Text = "O wins.";
						button10.Enabled = false;
					}
				}
				button1.Enabled = false;
			}
		}

		private void button2_Click(object sender, EventArgs e)
		{
			if (button10.Text == "X wins." || button10.Text == "O wins.")
			{
				button2.Enabled = false;
			}
			else
			{
				if (IfFirstPlayer() == true)
				{
					button2.Text = "X";
				}
				else
				{
					button2.Text = "O";
				}
				if (button2.Text == "X")
				{
					if ((button2.Text == button1.Text) && (button2.Text == button3.Text))
					{
						button10.Text = "X wins.";
						button10.Enabled = false;
					}
					if ((button2.Text == button5.Text) && (button2.Text == button8.Text))
					{
						button10.Text = "X wins.";
						button10.Enabled = false;
					}
				}
				else
				{
					if ((button2.Text == button1.Text) && (button2.Text == button3.Text))
					{
						button10.Text = "O wins.";
						button10.Enabled = false;
					}
					if ((button2.Text == button5.Text) && (button2.Text == button8.Text))
					{
						button10.Text = "O wins.";
						button10.Enabled = false;
					}
				}
				button2.Enabled = false;
			}
		}

		private void button3_Click(object sender, EventArgs e)
		{
			if (button10.Text == "X wins." || button10.Text == "O wins.")
			{
				button3.Enabled = false;
			}
			else
			{
				if (IfFirstPlayer() == true)
				{
					button3.Text = "X";
				}
				else
				{
					button3.Text = "O";
				}
				if (button3.Text == "X")
				{
					if ((button3.Text == button1.Text) && (button3.Text == button2.Text))
					{
						button10.Text = "X wins.";
						button10.Enabled = false;
					}
					if ((button3.Text == button6.Text) && (button3.Text == button9.Text))
					{
						button10.Text = "X wins.";
						button10.Enabled = false;
					}
					if ((button3.Text == button5.Text) && (button3.Text == button7.Text))
					{
						button10.Text = "X wins.";
						button10.Enabled = false;
					}
				}
				else
				{
					if ((button3.Text == button1.Text) && (button3.Text == button2.Text))
					{
						button10.Text = "O wins.";
						button10.Enabled = false;
					}
					if ((button3.Text == button6.Text) && (button3.Text == button9.Text))
					{
						button10.Text = "O wins.";
						button10.Enabled = false;
					}
					if ((button3.Text == button5.Text) && (button3.Text == button7.Text))
					{
						button10.Text = "O wins.";
						button10.Enabled = false;
					}
				}
				button3.Enabled = false;
			}
		}

		private void button4_Click(object sender, EventArgs e)
		{
			if (button10.Text == "X wins." || button10.Text == "O wins.")
			{
				button4.Enabled = false;
			}
			else
			{
				if (IfFirstPlayer() == true)
				{
					button4.Text = "X";
				}
				else
				{
					button4.Text = "O";
				}
				if (button4.Text == "X")
				{
					if ((button4.Text == button1.Text) && (button4.Text == button7.Text))
					{
						button10.Text = "X wins.";
						button10.Enabled = false;
					}
					if ((button4.Text == button5.Text) && (button4.Text == button6.Text))
					{
						button10.Text = "X wins.";
						button10.Enabled = false;
					}
				}
				else
				{
					if ((button4.Text == button1.Text) && (button4.Text == button7.Text))
					{
						button10.Text = "O wins.";
						button10.Enabled = false;
					}
					if ((button4.Text == button5.Text) && (button4.Text == button6.Text))
					{
						button10.Text = "O wins.";
						button10.Enabled = false;
					}
				}
				button4.Enabled = false;
			}
		}

		private void button5_Click(object sender, EventArgs e)
		{
			if (button10.Text == "X wins." || button10.Text == "O wins.")
			{
				button5.Enabled = false;
			}
			else
			{
				if (IfFirstPlayer() == true)
				{
					button5.Text = "X";
				}
				else
				{
					button5.Text = "O";
				}
				if (button5.Text == "X")
				{
					if ((button5.Text == button1.Text) && (button5.Text == button9.Text))
					{
						button10.Text = "X wins.";
						button10.Enabled = false;
					}
					if ((button5.Text == button3.Text) && (button5.Text == button7.Text))
					{
						button10.Text = "X wins.";
						button10.Enabled = false;
					}
					if ((button5.Text == button2.Text) && (button5.Text == button8.Text))
					{
						button10.Text = "X wins.";
						button10.Enabled = false;
					}
					if ((button5.Text == button4.Text) && (button5.Text == button6.Text))
					{
						button10.Text = "X wins.";
						button10.Enabled = false;
					}
				}
				else
				{
					if ((button5.Text == button1.Text) && (button5.Text == button9.Text))
					{
						button10.Text = "O wins.";
						button10.Enabled = false;
					}
					if ((button5.Text == button3.Text) && (button5.Text == button7.Text))
					{
						button10.Text = "O wins.";
						button10.Enabled = false;
					}
					if ((button5.Text == button2.Text) && (button5.Text == button8.Text))
					{
						button10.Text = "O wins.";
						button10.Enabled = false;
					}
					if ((button5.Text == button4.Text) && (button5.Text == button6.Text))
					{
						button10.Text = "O wins.";
						button10.Enabled = false;
					}
				}
				button5.Enabled = false;
			}
		}

		private void button6_Click(object sender, EventArgs e)
		{
			if (button10.Text == "X wins." || button10.Text == "O wins.")
			{
				button6.Enabled = false;
			}
			else
			{
				if (IfFirstPlayer() == true)
				{
					button6.Text = "X";
				}
				else
				{
					button6.Text = "O";
				}
				if (button6.Text == "X")
				{
					if ((button6.Text == button3.Text) && (button6.Text == button9.Text))
					{
						button10.Text = "X wins.";
						button10.Enabled = false;
					}
					if ((button6.Text == button4.Text) && (button6.Text == button5.Text))
					{
						button10.Text = "X wins.";
						button10.Enabled = false;
					}
				}
				else
				{
					if ((button6.Text == button3.Text) && (button6.Text == button9.Text))
					{
						button10.Text = "O wins.";
						button10.Enabled = false;
					}
					if ((button6.Text == button4.Text) && (button6.Text == button5.Text))
					{
						button10.Text = "O wins.";
						button10.Enabled = false;
					}
				}
				button6.Enabled = false;
			}
		}

		private void button7_Click(object sender, EventArgs e)
		{
			if (button10.Text == "X wins." || button10.Text == "O wins.")
			{
				button7.Enabled = false;
			}
			else
			{
				if (IfFirstPlayer() == true)
				{
					button7.Text = "X";
				}
				else
				{
					button7.Text = "O";
				}
				if (button7.Text == "X")
				{
					if ((button7.Text == button1.Text) && (button7.Text == button4.Text))
					{
						button10.Text = "X wins.";
						button10.Enabled = false;
					}
					if ((button7.Text == button3.Text) && (button7.Text == button5.Text))
					{
						button10.Text = "X wins.";
						button10.Enabled = false;
					}
					if ((button7.Text == button8.Text) && (button7.Text == button9.Text))
					{
						button10.Text = "X wins.";
						button10.Enabled = false;
					}
				}
				else
				{
					if ((button7.Text == button1.Text) && (button7.Text == button4.Text))
					{
						button10.Text = "O wins.";
						button10.Enabled = false;
					}
					if ((button7.Text == button3.Text) && (button7.Text == button5.Text))
					{
						button10.Text = "O wins.";
						button10.Enabled = false;
					}
					if ((button7.Text == button8.Text) && (button7.Text == button9.Text))
					{
						button10.Text = "O wins.";
						button10.Enabled = false;
					}
				}
				button7.Enabled = false;
			}
		}

		private void button8_Click(object sender, EventArgs e)
		{
			if (button10.Text == "X wins." || button10.Text == "O wins.")
			{
				button8.Enabled = false;
			}
			else
			{
				if (IfFirstPlayer() == true)
				{
					button8.Text = "X";
				}
				else
				{
					button8.Text = "O";
				}
				if (button8.Text == "X")
				{
					if ((button8.Text == button2.Text) && (button8.Text == button5.Text))
					{
						button10.Text = "X wins.";
						button10.Enabled = false;
					}
					if ((button8.Text == button7.Text) && (button8.Text == button9.Text))
					{
						button10.Text = "X wins.";
						button10.Enabled = false;
					}
				}
				else
				{
					if ((button8.Text == button2.Text) && (button8.Text == button5.Text))
					{
						button10.Text = "O wins.";
						button10.Enabled = false;
					}
					if ((button8.Text == button7.Text) && (button8.Text == button9.Text))
					{
						button10.Text = "O wins.";
						button10.Enabled = false;
					}
				}
				button8.Enabled = false;
			}
		}

		private void button9_Click(object sender, EventArgs e)
		{
			if (button10.Text == "X wins." || button10.Text == "O wins.")
			{
				button9.Enabled = false;
			}
			else
			{
				if (IfFirstPlayer() == true)
				{
					button9.Text = "X";
				}
				else
				{
					button9.Text = "O";
				}
				if (button9.Text == "X")
				{
					if ((button9.Text == button1.Text) && (button9.Text == button5.Text))
					{
						button10.Text = "X wins.";
						button10.Enabled = false;
					}
					if ((button9.Text == button3.Text) && (button9.Text == button6.Text))
					{
						button10.Text = "X wins.";
						button10.Enabled = false;
					}
					if ((button9.Text == button7.Text) && (button9.Text == button8.Text))
					{
						button10.Text = "X wins.";
						button10.Enabled = false;
					}
				}
				else
				{
					if ((button9.Text == button1.Text) && (button9.Text == button5.Text))
					{
						button10.Text = "O wins.";
						button10.Enabled = false;
					}
					if ((button9.Text == button3.Text) && (button9.Text == button6.Text))
					{
						button10.Text = "O wins.";
						button10.Enabled = false;
					}
					if ((button9.Text == button7.Text) && (button9.Text == button8.Text))
					{
						button10.Text = "O wins.";
						button10.Enabled = false;
					}
				}
				button9.Enabled = false;
			}
		}

		private void button10_Click(object sender, EventArgs e)
		{
		}
	}
}
