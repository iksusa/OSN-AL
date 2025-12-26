using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите первое число:");
        string a = Console.ReadLine();

        Console.WriteLine("Введите второе число:");
        string b = Console.ReadLine();

        if (a == b)
        {
            Console.WriteLine("Числа равны");
        }
        else
        {
            Console.WriteLine("Числа не равны");
        }

        Console.ReadLine();
    }
}