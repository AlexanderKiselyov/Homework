namespace ParseTree
{
	/// can construct Parse Tree and returns its result, constructs and prints Parse Tree
	public class ParseTree
	{
		public static int ParseTreeCounter(string sentence)
		{
			return ParseTreeConstructor.ConstructParseTree(sentence).Result();
		}

		public static void ParseTreeViewer(string sentence)
		{
			ParseTreeConstructor.ConstructParseTree(sentence).Print();
		}
	}
}