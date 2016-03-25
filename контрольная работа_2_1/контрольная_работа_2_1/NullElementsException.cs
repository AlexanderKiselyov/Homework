using System;

namespace PriorityQueue
{
	[Serializable]
	public class NullElementsException : Exception
	{
		public NullElementsException() { }
		public NullElementsException(string message) : base(message) { }
		public NullElementsException(string message, Exception inner) :

		base(message, inner)
		{ }

		protected NullElementsException(
		  System.Runtime.Serialization.SerializationInfo info,
		  System.Runtime.Serialization.StreamingContext context)
			: base(info, context)
		{ }
	}

}
