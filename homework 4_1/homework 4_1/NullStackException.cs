using System;

namespace ParseTree
{
	/// writes that we tried to get value from null reference while working with stack
	[Serializable]
	public class NullStackException : Exception
	{
		public NullStackException() { }
		public NullStackException(string message) : base(message) { }
		public NullStackException(string message, Exception inner) :

		base(message, inner)
		{ }

		protected NullStackException(
		  System.Runtime.Serialization.SerializationInfo info,
		  System.Runtime.Serialization.StreamingContext context)
			: base(info, context)
		{ }
	}
}