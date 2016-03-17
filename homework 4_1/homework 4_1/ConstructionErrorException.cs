using System;

namespace ParseTree
{
	/// write a message about error in ParseTreeConstruction
	[Serializable]
	public class ConstructionErrorException : Exception
	{
		public ConstructionErrorException() { }
		public ConstructionErrorException(string message) : base(message) { }
		public ConstructionErrorException(string message, Exception inner) :

		base(message, inner)
		{ }

		protected ConstructionErrorException(
		  System.Runtime.Serialization.SerializationInfo info,
		  System.Runtime.Serialization.StreamingContext context)
			: base(info, context)
		{ }
	}
}

