using System;
using MongoDB.Driver;
using MongoDB.Bson;
using System.Linq;

namespace PhoneDataBase
{
	public class DataBase
	{
		/// Connects to mongo server, creates data base and helps person to
		/// interact with a base.
		public static void Main()
		{
			string mongoClientName = "mongodb://localhost";
			var client = new MongoClient(mongoClientName);
			var database = client.GetDatabase("dictionary");
			var collection = database.GetCollection<Contact>("contacts");
			Console.WriteLine("Available commands:");
			Console.WriteLine("0 - exit;");
			Console.WriteLine("1 - new contact;");
			Console.WriteLine("2 - find phone number by name;");
			Console.WriteLine("3 - find name by phone number;");
			Console.WriteLine("4 - show current contacts.");
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
								Console.WriteLine("The numbers of {0} are: {1}", name, phoneNumber);
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
		/// Adds new contact with name and phone number if possible
		/// </summary>
		/// <param name="collection"></param>
		/// <param name="name"></param>
		/// <param name="phoneNumber"></param>
		private static void NewContact(IMongoCollection<Contact> collection, string name, string phoneNumber)
 		{
 			if (FindPhoneByName(collection, name) == null && FindNameByPhone(collection, phoneNumber) == null)
 			{
 				collection.InsertOne(new Contact() { Name = name, Phone = phoneNumber });
 			}
 			else
 			{
 				string contact = (FindPhoneByName(collection, name) == null) ? phoneNumber : name;
 				Console.WriteLine("Name '{0}' has been added to the base earlier.", contact);
 			}
 		}

		/// <summary>
		/// Searches for a name by phone if possible
		/// </summary>
		/// <param name="collection"></param>
		/// <param name="phoneNumber"></param>
		/// <returns></returns>
		private static string FindNameByPhone(IMongoCollection<Contact> collection, string phoneNumber)
 		{
 			foreach (var contact in collection.Find(new BsonDocument()).ToList())
 			{
 				if (contact.Phone == phoneNumber)
 				{
 					return contact.Name;
 				}
 			}
 			return null;
 		}

		/// <summary>
		/// seaches for a phone by name if possible
		/// </summary>
		/// <param name="collection"></param>
		/// <param name="name"></param>
		/// <returns></returns>
		private static string FindPhoneByName(IMongoCollection<Contact> collection, string name)
 		{
 			foreach (var contact in collection.Find(new BsonDocument()).ToList())
 			{
 				if (contact.Name == name)
 				{
 					return contact.Phone;
 				}
 			}
 			return null;
 		}
	}
}