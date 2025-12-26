
class Program
{
    static void Main()
    {
        Console.WriteLine("Введите сумму вклада:");
        decimal sum = decimal.Parse(Console.ReadLine());

        Console.WriteLine("Введите количество месяцев:");
        int months = int.Parse(Console.ReadLine());

        for (int i = 0; i < months; i++)
        {
            sum = sum + sum * 0.07m;
        }

        Console.WriteLine("Итоговая сумма: " + sum);
    }
}