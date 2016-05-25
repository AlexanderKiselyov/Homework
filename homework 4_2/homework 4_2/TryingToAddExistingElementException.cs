using System;

namespace UniqueList
{
	/// <summary>
	/// exception which shows information about adding existing element to the list
	/// </summary>
	[Serializable]
	public class TryingToAddExistingElementException : Exception
	{
		public TryingToAddExistingElementException() { }
		public TryingToAddExistingElementException(string message) : base(message) { }
		public TryingToAddExistingElementException(string message, Exception inner) : base(message, inner) { }
		protected TryingToAddExistingElementException(
		  System.Runtime.Serialization.SerializationInfo info,
		  System.Runtime.Serialization.StreamingContext context) : base(info, context)
		{ }
	}
}
