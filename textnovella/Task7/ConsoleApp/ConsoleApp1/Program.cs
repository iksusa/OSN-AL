using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите первое число: ");
        int a = Convert.ToInt32(Console.ReadLine());

        Console.Write("Введите второе число: ");
        int b = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Выберите операцию:");
        Console.WriteLine("1 - Сложение");
        Console.WriteLine("2 - Вычитание");
        Console.WriteLine("3 - Умножение");

        int operation = Convert.ToInt32(Console.ReadLine());

        switch (operation)
        {
            case 1:
                Console.WriteLine("Результат: " + (a + b));
                break;

            case 2:
                Console.WriteLine("Результат: " + (a - b));
                break;

            case 3:
                Console.WriteLine("Результат: " + (a * b));
                break;

            default:
                Console.WriteLine("Ошибка: выберите число от 1 до 3!");
                break;
        }
    }
}