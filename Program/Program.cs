using System;

namespace Program
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Здравствуйте, вас приветствует математическая программа");
            Console.WriteLine("Пожалуйста введите число: ");

            String s = Console.ReadLine();

            if (s == "q")
            {
                return;
            }
            int n = Int32.Parse(s);
            ulong c1 = 1; 
            uint c2 = 0;
            for (uint i = 1; i <= n; i++)
            {
                c1 *= i;
                c2 += i;
            }
            Console.WriteLine($"Факториал {n} равен {c1}"); 
            Console.WriteLine($"Сума от 1 до {n} равна {c2}");
            Console.WriteLine($"максимальное четное число меньшее или равное {n}: {(n % 2 == 0 ? n : n - 1)}");
            Console.ReadLine();
        }
    }
}
