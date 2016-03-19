using System;

namespace NewHashTable
{
	/// throws exceprion if the array is empty and we try to pop from it
	[Serializable]
	public class ListNullException : Exception
	{
		public ListNullException() { }
		public ListNullException(string message) : base(message) { }
		public ListNullException(string message, Exception inner) :

		base(message, inner)
		{ }

		protected ListNullException(
		  System.Runtime.Serialization.SerializationInfo info,
		  System.Runtime.Serialization.StreamingContext context)
			: base(info, context)
		{ }
	}
}