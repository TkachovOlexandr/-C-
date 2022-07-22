using WorkWithArray;
using WorkWithHuman;

int[] numbers = new int[] { 12, 35, 67, 1, 4, 80, 29 };
Predicate<int> predicate = (x) => x % 2 == 0;
MyArray myArray = new MyArray();
myArray.ShowArray(numbers, predicate);

Console.WriteLine();

HumanInfo[] humans = new HumanInfo[] { new HumanInfo("Bob", 35), new HumanInfo(), new HumanInfo("Kim", 18) };
for (short i = 0; i < humans.Length; i++)
    humans[i].ShowAdults();

Console.WriteLine();

Predicate<int> predicate_1 = (x) => x < 18;
for (short i = 0; i < humans.Length; i++)
    humans[i].ShowHumans(predicate_1);

Console.WriteLine();

Predicate<string> predicate_2 = (x) => x.Length > 5;
for (short i = 0; i < humans.Length; i++)
    humans[i].ShowHumans(predicate_2);

Console.WriteLine();

Predicate<string> predicate_3 = (x) => x[0].ToString().ToLower().Equals("a") || x[x.Length - 1].ToString().ToLower().Equals("a");
for (short i = 0; i < humans.Length; i++)
    humans[i].ShowHumans(predicate_3);