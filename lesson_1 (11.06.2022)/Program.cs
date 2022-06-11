using System;

namespace my_namespace
{
    class Program
    {
        static void Main(string[] args)
        {
            //object continuation;
            //do
            //{
            //    Console.Write("Write number a: ");
            //    object a = Console.ReadLine();
            //    Console.Write("Write number b: ");
            //    object b = Console.ReadLine();
            //    Console.Write("Write mathematical sign: ");
            //    object math_sign = Console.ReadLine();

            //    if (math_sign.ToString() == "+")
            //        Console.WriteLine($"a + b = {a} + {b} = {int.Parse(a.ToString()) + int.Parse(b.ToString())}\n");
            //    else if (math_sign.ToString() == "-")
            //        Console.WriteLine($"a + b = {a} - {b} = {int.Parse(a.ToString()) - int.Parse(b.ToString())}\n");
            //    else if (math_sign.ToString() == "*")
            //        Console.WriteLine($"a + b = {a} * {b} = {int.Parse(a.ToString()) * int.Parse(b.ToString())}\n");
            //    else if (math_sign.ToString() == "/" && float.Parse(b.ToString()) != 0)
            //        Console.WriteLine($"a + b = {a} / {b} = {float.Parse(a.ToString()) / float.Parse(b.ToString())}\n");
            //    else if (math_sign.ToString() == "/" && float.Parse(b.ToString()) == 0)
            //        Console.WriteLine("You can't divide by 0\n");
            //    else
            //        Console.WriteLine("An incorrect mathematical sign was entered\n");

            //    Console.Write("If you want to continue - enter 1; if you want to complete the work - enter something else: ");
            //    continuation = Console.ReadLine();
            //} while (int.Parse(continuation.ToString()) == 1);

            //Console.Write("Write name: ");
            //object var_name = Console.ReadLine();
            //Console.Write("Write number of repetitions: ");
            //int rep_num = int.Parse(Console.ReadLine());
            //if (rep_num < 0)
            //    rep_num *= -1;
            //for (int i = 0; i < int.Parse(rep_num.ToString()); i++)
            //    Console.Write($"{var_name} ");

            //Console.Write("Write number: ");
            //int num = int.Parse(Console.ReadLine());
            //for (int i = 1; i <= 10; i++)
            //    Console.WriteLine($"{num} * {i} = {num * i} ");

            Console.Write("Write first number: ");
            int num_1 = int.Parse(Console.ReadLine());
            Console.Write("Write second number: ");
            int num_2 = int.Parse(Console.ReadLine());
            if (num_1 > num_2)
            {
                int a = num_1;
                num_1 = num_2;
                num_2 = a;
            }
            int answer = 1;
            for (int i = num_1; i <= num_2; i++)
                answer *= i;
            Console.WriteLine(answer);

            Console.Write("Write name: ");
            object var_name = Console.ReadLine();
            for (int i = 0; i < var_name.ToString().Length; i++)
                Console.WriteLine(var_name.ToString()[i]);
        }
    }
}