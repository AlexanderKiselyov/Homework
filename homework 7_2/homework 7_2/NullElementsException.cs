using System;

namespace Set
{
	/// exception for deleting an element from an empty list
	[Serializable]
	public class NullElementsException : Exception
	{
		public NullElementsException() { }
		public NullElementsException(string message) : base(message) { }
		public NullElementsException(string message, Exception inner)
			: base(message, inner) { }
		protected NullElementsException(
			System.Runtime.Serialization.SerializationInfo info,
			System.Runtime.Serialization.StreamingContext context)
			: base(info, context) { }
	}
}
