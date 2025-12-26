using System;

class Program
{
    static void Main()
    {
        while (true)
        {
            Console.WriteLine("Введите первое число:");
            int a = int.Parse(Console.ReadLine());

            Console.WriteLine("Введите второе число:");
            int b = int.Parse(Console.ReadLine());

            if (a >= 0 && a <= 10 && b >= 0 && b <= 10)
            {
                Console.WriteLine("Результат: " + (a * b));
                break;
            }
            else
            {
                Console.WriteLine("Числа введены неверно, попробуйте ещё раз.");
            }
        }
    }
}