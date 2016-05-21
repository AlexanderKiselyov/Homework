using System;
using System.Drawing;
using System.Windows.Forms;

namespace Calculator
{
	public partial class Calculator : Form
	{
		private Button[] button = new Button[16];
		private TextBox textBox = new TextBox();

		private int leftValue = 0;
		private int rightValue = 0;
		private char operation = '+';

		public Calculator()
		{
			Text = "Calculator";
			Size = new Size(220, 293);
			StartPosition = FormStartPosition.CenterScreen;
			FormBorderStyle = FormBorderStyle.Fixed3D;
			MaximizeBox = false;

			AddButtons();

			textBox.Text = "0";
			textBox.Size = new Size(201, 50);
			textBox.Location = new Point(0,0);
			Controls.Add(textBox);
		}

		private void AddButtons()
		{
			Size sizeOfButton = new Size(50, 50);
			button[0] = AddButton("button_0", 0.ToString(), sizeOfButton,
				new Point(50 * 1, 50 * 4));
			for (int i = 1; i < 10; i++)
			{
				button[i] = AddButton("button_" + i.ToString(), i.ToString(), sizeOfButton,
					new Point(50 * ((i - 1) % 3), 50 * ((i - 1) / 3 + 1)));
			}
			button[10] = AddButton("button_+", "+", sizeOfButton,
				new Point(50 * 3, 50 * 1));
			button[11] = AddButton("button_-", "-", sizeOfButton,
				new Point(50 * 3, 50 * 2));
			button[12] = AddButton("button_*", "*", sizeOfButton,
				new Point(50 * 3, 50 * 3));
			button[13] = AddButton("button_/", "/", sizeOfButton,
				new Point(50 * 3, 50 * 4));
			button[14] = AddButton("button_=", "=", sizeOfButton,
				new Point(50 * 2, 50 * 4));
			button[15] = AddButton("button_C", "C", sizeOfButton,
				new Point(50 * 0, 50 * 4));

			for (int i = 0; i < 10; i++)
			{
				button[i].Click += AddDigit;
			}
			for (int i = 10; i < 15; i++)
			{
				button[i].Click += AddSymbol;
			}
			button[15].Click += DeleteAllSymbols;
		}

		private Button AddButton(string name, string text, Size size, Point point)
		{
			var button = new Button();
			button.Name = name;
			button.Text = text;
			button.Size = size;
			button.Location = point;
			Controls.Add(button);
			return button;
		}

		private void AddDigit(object sender, EventArgs args)
		{
			if (textBox.Text == "Division by zero.")
			{
				textBox.Text = "";
			}
			else if (textBox.Text[0] == '0')
			{
				textBox.Text = "";
				operation = '+';
			}
			var button = sender as Button;
			textBox.Text += button.Text[0];
			rightValue *= 10;
			rightValue += button.Text[0] - '0';
		}

		private void AddSymbol(object sender, EventArgs args)
		{
			var button = sender as Button;
			if (!(textBox.Text[0] <= '9'
				&& textBox.Text[0] >= '0'))
			{
				if (leftValue != 0)
				{
					textBox.Text = leftValue.ToString();
				}
				textBox.Text += button.Text[0];
				operation = button.Text[0];
			}
			else
			{
				switch (operation)
				{
					case '+':
						{
							leftValue += rightValue;
							break;
						}
					case '-':
						{
							leftValue -= rightValue;
							break;
						}
					case '*':
						{
							leftValue *= rightValue;
							break;
						}
					case '/':
						{
							if (rightValue == 0)
							{
								textBox.Text = "Division by zero.";
								return;
							}
							leftValue /= rightValue;
							break;
						}
				}
				textBox.Text = leftValue.ToString();
				textBox.Text += button.Text[0];
				operation = button.Text[0];
				rightValue = 0;
			}
		}

		public void DeleteAllSymbols(object sender, EventArgs args)
		{
			textBox.Text = "0";
			leftValue = 0;
			rightValue = 0;
			operation = '+';
		}
	}
}
