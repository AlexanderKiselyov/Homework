using System;

namespace MyStack
{
	// Exception connected with an empty stack.
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