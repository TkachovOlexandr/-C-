using SQL_5;

PhoneBook phoneBook = new PhoneBook();
Console.WriteLine("All phone numbers:");
phoneBook.AllPhoneNumbers.ForEach(x => Console.Write($"{x}\n"));
Console.WriteLine();
phoneBook.Show();
phoneBook.Add("Jim", "Stone", 25, "+380 90 173 12 74");
phoneBook.Delete(11);