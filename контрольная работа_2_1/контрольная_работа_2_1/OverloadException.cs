using System;

namespace PriorityQueue
{
	[Serializable]
	public class OverloadException : Exception
	{
		public OverloadException() { }
		public OverloadException(string message) : base(message) { }
		public OverloadException(string message, Exception inner) :

		base(message, inner)
		{ }

		protected OverloadException(
		  System.Runtime.Serialization.SerializationInfo info,
		  System.Runtime.Serialization.StreamingContext context)
			: base(info, context)
		{ }
	}

}