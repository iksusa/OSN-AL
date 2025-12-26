using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите сумму вклада:");
        decimal sum = decimal.Parse(Console.ReadLine());

        Console.WriteLine("Введите количество месяцев:");
        int months = int.Parse(Console.ReadLine());

        int i = 0;
        while (i < months)
        {
            sum = sum + sum * 0.07m;
            i++;
        }

        Console.WriteLine("Итоговая сумма: " + sum);
    }
}