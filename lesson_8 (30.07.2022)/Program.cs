//Dictionary<string, string> dict = new Dictionary<string, string>();

//string data = File.ReadAllText("MyDictionary.TXT");
//string[] rows = data.Split("\n");
//string[] pairs;

//for (int i = 0; i < rows.Length; i++)
//{
//    pairs = rows[i].Split(" - ");
//    if (pairs.Length > 1)
//        dict.Add(pairs[0], pairs[1]);
//}

//foreach (var item in dict)
//    Console.WriteLine($"{item.Key} - {item.Value}");

//short choice = 0;
//do
//{
//    do
//    {
//        Console.WriteLine("\nIf you want to add a new word pair - enter '1';");
//        Console.WriteLine("if you want to find some translation - enter '2';");
//        Console.Write("if you want to finish the program execution - enter '3': ");
//        choice = short.Parse(Console.ReadLine());
//    } while (choice != 1 && choice != 2 && choice != 3);
//    if (choice == 1)
//    {
//        Console.Write("Enter an English word: ");
//        string engWord = Console.ReadLine();
//        Console.Write("Enter its translation: ");
//        string itsTranslation = Console.ReadLine();
//        dict.Add(engWord, itsTranslation);
//        File.AppendAllText("MyDictionary.TXT", $"{engWord} - {itsTranslation}\n");
//    }
//    else if (choice == 2)
//    {
//        Console.Write("Enter searching word: ");
//        string searchingWord = Console.ReadLine();
//        foreach (var item in dict)
//        {
//            if (item.Key.ToLower().Equals(searchingWord) || item.Value.ToLower().Equals(searchingWord))
//            {
//                Console.WriteLine($"{item.Key} - {item.Value}");
//                break;
//            }
//            Console.WriteLine(dict.Values.Last());
//            if (item.Equals(dict.Values.Last()))
//                Console.WriteLine("There is no such word in the dictionary!");
//        }
//    }
//} while (choice != 3);

using Shop;
using System.Text.Json;

List<Product> listWrite = new List<Product>();//as NON-JSON
listWrite.Add(new Product(1, "Red Hot Chili Peppers", 120));
listWrite.Add(new Product(2, "The Cranberries", 60));
listWrite.Add(new Product(3, "Sunflower Bean", 70));
string strWrite = JsonSerializer.Serialize<List<Product>>(listWrite);
//Console.WriteLine(strWrite);
File.WriteAllText("jsonData.json", strWrite);

List<Product> listRead = new List<Product>();//as JSON
string strRead = File.ReadAllText("jsonData.json");
listRead = JsonSerializer.Deserialize<List<Product>>(strRead);
//Console.WriteLine(listRead.First().ProductId);
for (int i = 0; i < listRead.Count; i++)
    Console.WriteLine(listRead.ElementAt(i));