using System;

namespace lesson_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Random random = new Random();
            //int min_random = 1;
            //int max_random = 10;
            //Console.Write("Write row number: ");
            //short size_r = short.Parse(Console.ReadLine());
            //Console.Write("Write colomn number: ");
            //short size_c = short.Parse(Console.ReadLine());
            //if (size_r < 0)
            //    size_r *= -1;
            //if (size_c < 0)
            //    size_c *= -1;
            //int[,] arr = new int[size_r, size_c];
            //for (int i = 0; i < size_r; i++)
            //{
            //    for (int j = 0; j < size_c; j++)
            //        arr[i,j] = random.Next(min_random, max_random);
            //}
            //for (int i = 0; i < size_r; i++)
            //{
            //    for (int j = 0; j < size_c; j++)
            //        Console.Write($"{arr[i, j]}\t");
            //    Console.Write("\n");
            //}
            //int[] sum = new int[size_c];
            //Array.Fill(sum, 0);
            //for (int i = 0; i < size_r; i++)
            //{
            //    for (int j = 0; j < size_c; j++)
            //        sum[j] += arr[i, j];
            //}
            //for (int i = 0; i < size_c; i++)
            //    Console.Write($"{sum[i]}\t");
            //Console.WriteLine(":Sum");

            //string fruits = new string("apple, pineapple, pear, mango, banana");
            //string all_fruits = fruits;
            //while (true)
            //{
            //    Console.Write("Add some fruit or type \"end\": ");
            //    string fruit = Console.ReadLine();
            //    if (!fruit.Equals("end"))
            //        all_fruits = string.Format("{0}, {1}", all_fruits, fruit);
            //    else
            //        break;
            //    Console.WriteLine(all_fruits);
            //}

            string lorem = new string("Lorem ipsum dolor sit amet, consectetur adipiscing elit. Aliquam pretium metus mauris. Donec eu dui tempus, imperdiet lorem vitae, tristique ex. Donec id mauris nec neque consequat auctor in eu nibh. Sed vitae lorem in dui sagittis imperdiet id interdum arcu. Proin vitae rutrum tellus. Vivamus in molestie sapien. Suspendisse sed laoreet odio, a finibus sapien. Proin mattis elit ut fringilla imperdiet. Sed id ullamcorper felis, at luctus eros.");
            string fixed_lorem = lorem.Replace('l', 'L');
            Console.WriteLine(fixed_lorem);
        }
    }
}