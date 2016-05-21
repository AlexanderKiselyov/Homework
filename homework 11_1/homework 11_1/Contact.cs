using MongoDB.Bson.Serialization.Attributes;

namespace PhoneDataBase
{
	/// <summary>
	/// A contact in a base which consists of a name and a phone.
	/// </summary>
	[BsonIgnoreExtraElements]
	public class Contact
	{
		public string Name { get; set; }
		public string Phone { get; set; }
	}
}