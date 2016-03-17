using System;

namespace ParseTree
{

	/// writes a message about wrong input in Operation Constructor
	[Serializable]
	public class WrongInputException : Exception
	{
		public WrongInputException() { }
		public WrongInputException(string message) : base(message) { }
		public WrongInputException(string message, Exception inner) :

		base(message, inner)
		{ }

		protected WrongInputException(
		System.Runtime.Serialization.SerializationInfo info,
		System.Runtime.Serialization.StreamingContext context)
			 : base(info, context)
		{ }
	}
}