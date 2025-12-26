using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Выберите размер вклада:");
        Console.WriteLine("1 - меньше 100");
        Console.WriteLine("2 - от 100 до 200");
        Console.WriteLine("3 - больше 200");

        string choice = Console.ReadLine();

        if (choice == "1")
        {
            Console.WriteLine("Начислено 5%");
        }
        else if (choice == "2")
        {
            Console.WriteLine("Начислено 7%");
        }
        else if (choice == "3")
        {
            Console.WriteLine("Начислено 10%");
        }
        else
        {
            Console.WriteLine("Неверный ввод");
        }

        Console.ReadLine();
    }
}