using System;

namespace ParseTree
{
	/// writes a message about wrong input in ParseTreeConstructor
	[Serializable]
	public class WrongConstructionInputException : Exception
	{
		public WrongConstructionInputException() { }
		public WrongConstructionInputException(string message) : base(message) { }
		public WrongConstructionInputException(string message, Exception inner) :

		base(message, inner)
		{ }

		protected WrongConstructionInputException(
		  System.Runtime.Serialization.SerializationInfo info,
		  System.Runtime.Serialization.StreamingContext context)
			: base(info, context)
		{ }
	}
}
