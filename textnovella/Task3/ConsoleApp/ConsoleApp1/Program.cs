using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите число:");
        string number = Console.ReadLine();

        if (number == "5" || number == "10")
        {
            Console.WriteLine("Число либо равно 5, либо равно 10");
        }
        else
        {
            Console.WriteLine("Неизвестное число");
        }

        Console.ReadLine();
    }
}