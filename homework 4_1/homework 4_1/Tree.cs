namespace Tree
{
	// class that realizes tree; can read income string, calculate it and convert to new string
	public class Tree
	{
		private string newExpression;
		private TreeInterface tree;
		private int index = 0;

		public Tree(string InitialExpression)
		{
			newExpression = InitialExpression;
			var operations = new Operations();
			tree = NewExpression(ref index, ref operations);
		}

		// function for calculating an expression
		private Operations NewExpression(ref int index, ref Operations operations)
		{
			index += 2;
			var treeNode = new Operations();
			switch (newExpression[index])
			{
				case '+':
					{
						treeNode = new Plus();
						break;
					}
				case '-':
					{
						treeNode = new Minus();
						break;
					}
				case '*':
					{
						treeNode = new Multiply();
						break;
					}
				case '/':
					{
						treeNode = new Divide();
						break;
					}
			}
			index += 2;
			if (newExpression[index] == '(')
			{
				var treeNodeLeft = new Operations();
				NewExpression(ref index, ref treeNodeLeft);
				treeNode.Left = treeNodeLeft;
			}
			else
			{
				var treeNodeLeft = new Operand(newExpression[index] - '0');
				treeNode.Left = treeNodeLeft;
				index += 2;
			}
			if (newExpression[index] == '(')
			{
				var treeNodeRight = new Operations();
				NewExpression(ref index, ref treeNodeRight);
				treeNode.Right = treeNodeRight;
			}
			else
			{
				var treeNodeRight = new Operand(newExpression[index] - '0');
				treeNode.Right = treeNodeRight;
				index += 2;
			}
			index += 2;
			operations = treeNode;
			return operations;
		}

		// prints the tree
		public void Print()
		{
			tree.Print();
		}

		// calculates the expression
		public int Calculate()
		{
			return tree.Calculation();
		}
	}
}
