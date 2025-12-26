using System;

class Program
{
    static void Main()
    {
        int points = 0;
        string choice;

        Console.WriteLine("Новелла «Признание»");
        Console.ReadLine();
        Console.WriteLine("1. Мальчик давно испытывает чувства к девочке.");
        Console.ReadLine();
        Console.WriteLine("2. Каждый день он думает, сказать ли ей о своей любви.");
        Console.ReadLine();
        Console.WriteLine("3. Однажды утром он решает, что больше не может молчать.");
        Console.ReadLine();
        Console.WriteLine("4. В школе он замечает девочку в коридоре.");
        Console.WriteLine("1 — Подойти сразу");
        Console.WriteLine("2 — Сделать вид, что не заметил");
        choice = Console.ReadLine();
        if (choice == "1") points++;
        Console.ReadLine();
        Console.WriteLine("5. Он подходит ближе, но начинает волноваться.");
        Console.ReadLine();
        Console.WriteLine("6. Мальчик сомневается: сейчас или позже.");
        Console.WriteLine("1 — Рискнуть сейчас");
        Console.WriteLine("2 — Подождать");
        choice = Console.ReadLine();
        if (choice == "1") points++;
        Console.ReadLine();
        Console.WriteLine("7. Он решает дождаться перемены.");
        Console.ReadLine();
        Console.WriteLine("8. На перемене девочка выходит во двор.");
        Console.ReadLine();
        Console.WriteLine("9. Мальчик следует за ней.");
        Console.ReadLine();
        Console.WriteLine("10. Он останавливает девочку и здоровается.");
        Console.WriteLine("1 — Уверенно");
        Console.WriteLine("2 — Смущённо");
        choice = Console.ReadLine();

        if (choice == "1") points++;
        Console.ReadLine();
        Console.WriteLine("11. Они немного разговаривают о школе.");
        Console.ReadLine();
        Console.WriteLine("12. Наступает неловкая пауза.");
        Console.ReadLine();
        Console.WriteLine("13. Мальчик набирается смелости.");
        Console.WriteLine("1 — Сказать прямо");
        Console.WriteLine("2 — Намекнуть");
        choice = Console.ReadLine();

        if (choice == "1") points++;
        Console.ReadLine();
        Console.WriteLine("14. Он признаётся девочке в любви.");
        Console.ReadLine();
        Console.WriteLine("15. Девочка отвечает ему...");
        Console.ReadLine();
        Console.WriteLine();
        if (points == 4)
        {
            Console.WriteLine("СЧАСТЛИВАЯ КОНЦОВКА");
            Console.WriteLine("Девочка улыбается и говорит, что тоже давно любит его.");
        }
        else if (points == 3)
        {
            Console.WriteLine("НЕОЖИДАННАЯ КОНЦОВКА");
            Console.WriteLine("Она признаётся, что знала о его чувствах и предлагает начать медленно.");
        }
        else if (points == 2)
        {
            Console.WriteLine("НЕОПРЕДЕЛЁННОСТЬ");
            Console.WriteLine("Она просит время, чтобы подумать.");
        }
        else if (points == 1)
        {
            Console.WriteLine("ДРУЖБА");
            Console.WriteLine("Она благодарит за честность и предлагает остаться друзьями.");
        }
        else
        {
            Console.WriteLine("ОТКАЗ");
            Console.WriteLine("Она говорит, что не готова к отношениям.");
        }

        Console.WriteLine();
        Console.WriteLine("Конец истории.");
    }
}