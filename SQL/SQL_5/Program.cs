﻿using SQL_5;

PhoneBook phoneBook = new PhoneBook();
Console.WriteLine("All phone numbers:");
phoneBook.AllPhoneNumbers.ForEach(x => Console.Write($"{x}\n"));
Console.WriteLine();
phoneBook.Show();
phoneBook.Add("Pit", "White", 53, "+380 81 264 80 62");
phoneBook.Delete(2);