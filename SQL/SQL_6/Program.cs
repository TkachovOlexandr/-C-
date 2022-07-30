using SQL_6;
using System.Text.Json;

PhoneBook phoneBook = new PhoneBook();
Console.WriteLine("All phone numbers:");
phoneBook.AllPhoneNumbers.ForEach(x => Console.Write($"{x}\n"));
Console.WriteLine();
phoneBook.Show();
phoneBook.Add("Kim", "Vinston", 15, "+380 31 941 37 55");
phoneBook.Delete(2);