using System;

namespace StackProgram
{
	/// Signals that one tried to get value from null reference
	/// while working with stack.
	[Serializable]
	public class StackNullException : Exception
	{
		public StackNullException() { }
		public StackNullException(string message) : base(message) { }
		public StackNullException(string message, Exception inner) :

		base(message, inner)
		{ }

		protected StackNullException(
		  System.Runtime.Serialization.SerializationInfo info,
		  System.Runtime.Serialization.StreamingContext context)
			: base(info, context)
		{ }
	}
}
