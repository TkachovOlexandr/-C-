namespace WorkWithArray
{
    internal class MyArray
    {
        public MyArray() { }

        public void ShowArray(int[] numbers, Predicate<int> predicate)
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                if (predicate(numbers[i]))
                    Console.Write($"{numbers[i]} ");
            }
        }
    }
}
