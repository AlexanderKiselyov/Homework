using System;

namespace StackProgram
{
	/// Checks if the Stack is empty and shows message.
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
