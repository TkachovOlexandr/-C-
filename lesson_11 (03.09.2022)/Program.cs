using System.Text.Json;
using DBSettings.DB;
//using Models.Civilization;

//People people = JsonSerializer.Deserialize<People>(File.ReadAllText("sample4.json"));
//people.people.ForEach(Console.WriteLine);

//StringConnection stringConnection = new StringConnection("DESKTOP-32NV42E", "Products", "True");
//File.WriteAllText("test.json", JsonSerializer.Serialize(stringConnection));

SingletonConnection connection = new SingletonConnection();
Console.WriteLine(connection.Connection.Connection);