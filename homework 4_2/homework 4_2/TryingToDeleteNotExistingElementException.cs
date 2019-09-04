using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniqueList
{
	/// <summary>
	/// exception which shows information about trying to delete not existing element from the list
	/// </summary>
	[Serializable]
	public class TryingToDeleteNotExistingElementException : Exception
	{
		public TryingToDeleteNotExistingElementException() { }
		public TryingToDeleteNotExistingElementException(string message) : base(message) { }
		public TryingToDeleteNotExistingElementException(string message, Exception inner) : base(message, inner) { }
		protected TryingToDeleteNotExistingElementException(
		  System.Runtime.Serialization.SerializationInfo info,
		  System.Runtime.Serialization.StreamingContext context) : base(info, context)
		{ }
	}
}
