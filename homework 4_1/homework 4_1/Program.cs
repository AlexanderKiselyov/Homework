using System;

namespace ParseTree
{
	class Program
	{
		static void Main()
		{
			string sentence = "(- (+ (+ (* (/ (+ 1 2) 3) 4) 5) 6) 7)";
			ParseTree.ParseTreeViewer(sentence);
			int result = ParseTree.ParseTreeCounter(sentence);
			Console.WriteLine(" = {0}", result);

		}
	}
}