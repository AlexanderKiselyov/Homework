using System;

namespace ParseTree
{
	/// writes a messahe if we try to count Operation's value while one of it children is null
	[Serializable]
	public class NullException : Exception
	{
		public NullException() { }
		public NullException(string message) : base(message) { }
		public NullException(string message, Exception inner) :

		base(message, inner)
		{ }

		protected NullException(
		System.Runtime.Serialization.SerializationInfo info,
		System.Runtime.Serialization.StreamingContext context)
			 : base(info, context)
		{ }
	}
}