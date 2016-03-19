using System;

namespace Calculator
{
	// Exception connected with an empty stack.
	[Serializable]
	public class OverflowException : Exception
	{
		public OverflowException() { }
		public OverflowException(string message) : base(message) { }
		public OverflowException(string message, Exception inner) :

		base(message, inner)
		{ }

		protected OverflowException(
		  System.Runtime.Serialization.SerializationInfo info,
		  System.Runtime.Serialization.StreamingContext context)
			: base(info, context)
		{ }
	}
}
