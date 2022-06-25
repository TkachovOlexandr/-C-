using SmartPhone;
using ShowCase;

Smartphone phone_1 = new Smartphone();
//Console.WriteLine($"{phone_1.Name}, {phone_1.Memory}Gb, {phone_1.Color}, {phone_1.Width}px, {phone_1.Height}px, {phone_1.Price}grn");

Smartphone phone_2 = new Smartphone("Apple iPhone 13 Pro", 256, "grey", 2532, 1170, 43000);
//Console.WriteLine($"{phone_2.Name}, {phone_2.Memory}Gb, {phone_2.Color}, {phone_2.Width}px, {phone_2.Height}px, {phone_2.Price}grn");

Smartphone phone_3 = new Smartphone(phone_2);
//Console.WriteLine($"{phone_3.Name}, {phone_3.Memory}Gb, {phone_3.Color}, {phone_3.Width}px, {phone_3.Height}px, {phone_3.Price}grn");

Smartphone phone_4 = new Smartphone("Xiaomi Redmi 10", 64, "white", 2400, 1080, 7000);
//Console.WriteLine($"{phone_2.Name}, {phone_2.Memory}Gb, {phone_2.Color}, {phone_2.Width}px, {phone_2.Height}px, {phone_2.Price}grn");

Smartphone phone_5 = new Smartphone("Samsung Galaxy M12", 32, "blue",1600, 720, 6500);
//Console.WriteLine($"{phone_5.Name}, {phone_5.Memory}Gb, {phone_5.Color}, {phone_5.Width}px, {phone_5.Height}px, {phone_5.Price}grn");

Smartphone phone_6 = new Smartphone("Nokia G20", 64, "black", 1600, 720, 7500);
//Console.WriteLine($"{phone_6.Name}, {phone_6.Memory}Gb, {phone_6.Color}, {phone_6.Width}px, {phone_6.Height}px, {phone_6.Price}grn");

Smartphone phone_7 = new Smartphone("Sony Xperia Pro-I", 256, "grey", 3840, 1644, 56000);
//Console.WriteLine($"{phone_7.Name}, {phone_7.Memory}Gb, {phone_7.Color}, {phone_7.Width}px, {phone_7.Height}px, {phone_7.Price}grn");

Smartphone[] phones = { phone_3, phone_4, phone_5, phone_6, phone_7 };
for (short i = 0; i < phones.Length; i++)
    Console.WriteLine(phones[i]);
int lowest_price = 0;
for (short i = 1; i < phones.Length; i++)
{
    if (phones[lowest_price].Price > phones[i].Price)
        lowest_price = i;
}
Console.WriteLine($"\nThe lowest prise has {phones[lowest_price].Name}: {phones[lowest_price].Price}grn");

Console.WriteLine(phone_2.Equals(phone_3));
Console.WriteLine(phone_3.Equals(phone_4));

Console.WriteLine();
Showcase showcase = new Showcase();
Console.WriteLine(showcase);
showcase.Add(new Smartphone("Sony Xperia Pro-I", 256, "grey", 3840, 1644, 56000));
Console.WriteLine(showcase);
//Showcase showcase_1 = new Showcase("Sony Xperia Pro-I", 256, "grey", 3840, 1644, 56000);
//Console.WriteLine(showcase_1);