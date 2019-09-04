using System;
using MongoDB.Driver;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System.Linq;

namespace PhoneDataBase
{
	public class DataBase
	{
		/// connects to mongo server, creates data base
		private static IMongoCollection<Contact> NewCollection()
		{
			string newClient = "mongodb://localhost";
			var client = new MongoClient(newClient);
			var phoneBase = client.GetDatabase("phonebase");
			var collection = phoneBase.GetCollection<Contact>("contacts");
			return collection;
		}

		static void Main()
		{
			var collection = NewCollection();
			Console.WriteLine("Available commands:");
			Console.WriteLine("0 - exit");
			Console.WriteLine("1 - add new contact");
			Console.WriteLine("2 - find phone number by name");
			Console.WriteLine("3 - find name by phone number");
			Console.WriteLine("4 - show current contacts");
			int command = Convert.ToInt32(Console.ReadLine());
			while (command != 0)
			{
				switch (command)
				{
					case 1:
						{
							Console.WriteLine("Enter name:");
							string name = Console.ReadLine();
							Console.WriteLine("Enter telephone number:");
							string number = Console.ReadLine();
							NewContact(collection, name, number);
							break;
						}
					case 2:
						{
							Console.WriteLine("Enter name:");
							var name = Console.ReadLine();
							string phoneNumber = FindPhoneByName(collection, name);
							if (phoneNumber == null)
							{
								Console.WriteLine("Nobody found.");
							}
							else
							{
								Console.WriteLine("The numbers of '{0}' are: {1}", name, phoneNumber);
							}
							break;
						}
					case 3:
						{
							Console.WriteLine("Enter number.");
							var phoneNumber = Console.ReadLine();
							string name = FindNameByPhone(collection, phoneNumber);
							if (name == null)
							{
								Console.WriteLine("Can't find any number.");
							}
							else
							{
								Console.WriteLine("Name of this person is: {0}", name);
							}
							break;
						}
					case 4:
						{
							AllContacts(collection);
							break;
						}
					default:
						{
							Console.WriteLine("Unexpected command.");
							break;
						}
				}
				Console.WriteLine("Enter new command:");
				command = Convert.ToInt32(Console.ReadLine());
			}
			Console.WriteLine("Closing...");
		}

		/// <summary>
		/// A contact in a base which consists of a name and a phone.
		/// </summary>
		[BsonIgnoreExtraElements]
		public class Contact
		{
			public string Name { get; set; }
			public string Phone { get; set; }
		}

		/// <summary>
		/// Adds new contact with name and phone number if possible
		/// </summary>
		/// <param name="collection"></param>
		/// <param name="name"></param>
		/// <param name="phoneNumber"></param>
		private static void NewContact(IMongoCollection<Contact> collection, string name, string phoneNumber)
 		{
 			if (FindNameByPhone(collection, phoneNumber) == null)
 			{
				var newName = new Contact() { Name = name, Phone = phoneNumber };
 				collection.InsertOne(newName);
 			}
 			else
 			{
 				string nameOfTheUser = FindNameByPhone(collection, phoneNumber);
 				Console.WriteLine("Name '{0}' has been added to the base earlier.", nameOfTheUser);
 			}
 		}

		/// <summary>
		/// searches for a name by phone if possible
		/// </summary>
		/// <param name="collection"></param>
		/// <param name="phoneNumber"></param>
		/// <returns></returns>
		private static string FindNameByPhone(IMongoCollection<Contact> collection, string phoneNumber)
 		{
 			foreach (var nameOfTheUser in collection.Find(new BsonDocument()).ToList())
 			{
 				if (nameOfTheUser.Phone == phoneNumber)
 				{
 					return nameOfTheUser.Name;
 				}
 			}
 			return null;
 		}

		/// <summary>
		/// searches for a phone by name if possible
		/// </summary>
		/// <param name="collection"></param>
		/// <param name="name"></param>
		/// <returns></returns>
		private static string FindPhoneByName(IMongoCollection<Contact> collection, string name)
 		{
 			foreach (var nameOfTheUser in collection.Find(new BsonDocument()).ToList())
 			{
 				if (nameOfTheUser.Name == name)
 				{
 					return nameOfTheUser.Phone;
 				}
 			}
 			return null;
 		}

		/// <summary>
		/// shows all contacts from the phone base
		/// </summary>
		/// <param name="collection"></param>
		private static void AllContacts(IMongoCollection<Contact> collection)
		{
			var list = collection.Find(new BsonDocument()).ToList();
			int number = 0;
			Console.WriteLine("Names and phones:");
			foreach (var person in list)
			{
				number++;
				Console.WriteLine("{0} - {1};", person.Name, person.Phone);
			}
			if (number != 0)
			{
				Console.WriteLine("The list is over.");
			}
			else
			{
				Console.WriteLine("The list is empty.");
			}
		}
	}
}