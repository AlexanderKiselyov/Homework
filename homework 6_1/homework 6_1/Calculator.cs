using System;
using System.Drawing;
using System.Windows.Forms;

namespace Calculator
{
	/// <summary>
	/// counts arithmetic expressions
	/// </summary>
	public partial class Calculator : Form
	{
		private Button[] button = new Button[16];
		private string operation = "+";
		private string preOperation = "+";


		/// <summary>
		/// creates calculator and its parametres
		/// </summary>
		public Calculator()
		{
			Size = new Size(293, 379);
			StartPosition = FormStartPosition.CenterScreen;
			FormBorderStyle = FormBorderStyle.Fixed3D;
			MaximizeBox = false;
			InitializeComponent();
			AddButtons();
		}

		/// <summary>
		/// adds buttons
		/// </summary>
		private void AddButtons()
		{
			firstDisplay.Text = "0";
			button[0] = button10;
			button[1] = button1;
			button[2] = button2;
			button[3] = button3;
			button[4] = button4;
			button[5] = button5;
			button[6] = button6;
			button[7] = button7;
			button[8] = button8;
			button[9] = button9;
			button[10] = button11;
			button[11] = button12;
			button[12] = button13;
			button[13] = button14;
			button[14] = button15;
			button[15] = button16;
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

		/// <summary>
		/// adds digit to the text box
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="args"></param>
		private void AddDigit(object sender, EventArgs args)
		{
			var button = sender as Button;
			if (firstDisplay.Text == "0")
			{
				firstDisplay.Text = button.Text;
			}
			else
			{
				firstDisplay.Text += button.Text;
			}
		}

		/// <summary>
		/// adds operation to the text box
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="args"></param>
		private void AddSymbol(object sender, EventArgs args)
		{
			var button = sender as Button;
			switch (button.Text)
			{
				case "=":
					{
						int firstElement = Stack.Pop();
						int secondElement = Convert.ToInt32(firstDisplay.Text);
						switch (operation)
						{
							case "+":
								{
									secondDisplay.Text = Convert.ToString(firstElement + secondElement);
									firstDisplay.Text = secondDisplay.Text;
									Stack.Push(Convert.ToInt32(secondDisplay.Text));
									break;
								}
							case "-":
								{
									secondDisplay.Text = Convert.ToString(firstElement - secondElement);
									firstDisplay.Text = secondDisplay.Text;
									Stack.Push(Convert.ToInt32(secondDisplay.Text));
									break;
								}
							case "*":
								{
									secondDisplay.Text = Convert.ToString(firstElement * secondElement);
									firstDisplay.Text = secondDisplay.Text;
									Stack.Push(Convert.ToInt32(secondDisplay.Text));
									break;
								}
							case "/":
								{
									if (secondElement == 0)
									{
										secondDisplay.Text = "Error: delete by 0.";
										break;
									}
									secondDisplay.Text = Convert.ToString(firstElement / secondElement);
									firstDisplay.Text = secondDisplay.Text;
									Stack.Push(Convert.ToInt32(secondDisplay.Text));
									break;
								}
						}
						break;
					}
				default:
					{
						Stack.Push(Convert.ToInt32(firstDisplay.Text));
						operation = button.Text;
						firstDisplay.Text = "0";
						break;
					}
			}
			if (Stack.stack.Count == 2)
			{
				int firstElement = Stack.Pop();
				int secondElement = Stack.Pop();
				switch (preOperation)
				{
					case "+":
						{
							secondDisplay.Text = Convert.ToString(firstElement + secondElement);
							Stack.Push(Convert.ToInt32(secondDisplay.Text));
							break;
						}
					case "-":
						{
							secondDisplay.Text = Convert.ToString(firstElement - secondElement);
							Stack.Push(Convert.ToInt32(secondDisplay.Text));
							break;
						}
					case "*":
						{
							secondDisplay.Text = Convert.ToString(firstElement * secondElement);
							Stack.Push(Convert.ToInt32(secondDisplay.Text));
							break;
						}
					case "/":
						{
							if (secondElement == 0)
							{
								firstDisplay.Text = "Error: delete by 0.";
								break;
							}
							secondDisplay.Text = Convert.ToString(firstElement + secondElement);
							Stack.Push(Convert.ToInt32(secondDisplay.Text));
							break;
						}
				}
				firstDisplay.Text = "0";
			}
			preOperation = operation;
		}

		/// <summary>
		/// deletes all symbols from the text box
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="args"></param>
		private void DeleteAllSymbols(object sender, EventArgs args)
		{
			firstDisplay.Text = "0";
			secondDisplay.Text = "";
			Stack.Clear();
		}
	}
}