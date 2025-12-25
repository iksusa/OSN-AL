using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите число:");
        string number = Console.ReadLine();

        if (number == "6" || number == "7" || number == "8" || number == "9")
        {
            Console.WriteLine("Число больше 5 и меньше 10");
        }
        else
        {
            Console.WriteLine("Неизвестное число");
        }

        Console.ReadLine();
    }
}