using System;

class Program
{
    static void Main()
    {
        int scene = 1;
        string choice;

        Console.WriteLine("Новелла «Признание»");
        Console.WriteLine("Нажмите Enter, чтобы начать...");
        Console.ReadLine();

        while (true)
        {
            switch (scene)
            {
                case 1:
                    Console.WriteLine("1. Мальчик давно испытывает чувства к девочке.");
                    Console.ReadLine();
                    scene = 2;
                    break;

                case 2:
                    Console.WriteLine("2. Он думает о ней каждое утро.");
                    Console.ReadLine();
                    scene = 3;
                    break;

                case 3:
                    Console.WriteLine("3. Сегодня он решает, что больше не может молчать.");
                    Console.ReadLine();
                    scene = 4;
                    break;

                case 4:
                    Console.WriteLine("4. В школе он замечает её в коридоре.");
                    Console.WriteLine("1 — Подойти сразу");
                    Console.WriteLine("2 — Сделать вид, что не заметил");
                    choice = Console.ReadLine();
                    scene = (choice == "1") ? 5 : 6;
                    break;

                case 5:
                    Console.WriteLine("5. Он подходит к ней.");
                    Console.ReadLine();
                    scene = 7;
                    break;

                case 6:
                    Console.WriteLine("6. Он проходит мимо, но чувствует сожаление.");
                    Console.ReadLine();
                    scene = 8;
                    break;

                case 7:
                    Console.WriteLine("7. Девочка улыбается ему.");
                    Console.WriteLine("1 — Заговорить уверенно");
                    Console.WriteLine("2 — Смущённо поздороваться");
                    choice = Console.ReadLine();
                    scene = (choice == "1") ? 9 : 10;
                    break;

                case 8:
                    Console.WriteLine("8. Он решает поговорить с ней на перемене.");
                    Console.ReadLine();
                    scene = 11;
                    break;

                case 9:
                    Console.WriteLine("9. Разговор идёт легко.");
                    Console.ReadLine();
                    scene = 12;
                    break;

                case 10:
                    Console.WriteLine("10. Возникает неловкая пауза.");
                    Console.WriteLine("1 — Продолжить разговор");
                    Console.WriteLine("2 — Уйти");
                    choice = Console.ReadLine();
                    scene = (choice == "1") ? 12 : 101;
                    break;

                case 11:
                    Console.WriteLine("11. На перемене он видит её во дворе.");
                    Console.WriteLine("1 — Подойти");
                    Console.WriteLine("2 — Передумать");
                    choice = Console.ReadLine();
                    scene = (choice == "1") ? 12 : 102;
                    break;

                case 12:
                    Console.WriteLine("12. Они говорят о школе и уроках.");
                    Console.ReadLine();
                    scene = 13;
                    break;

                case 13:
                    Console.WriteLine("13. Наступает тишина.");
                    Console.ReadLine();
                    scene = 14;
                    break;

                case 14:
                    Console.WriteLine("14. Мальчик чувствует, что момент близко, чтобы признаться.");
                    Console.ReadLine();
                    scene = 15;
                    break;

                case 15:
                    Console.WriteLine("15. Он сомневается в последний раз.");
                    Console.WriteLine("1 — Рискнуть");
                    Console.WriteLine("2 — Отложить");
                    choice = Console.ReadLine();
                    scene = (choice == "1") ? 16 : 103; break;

                case 16:
                    Console.WriteLine("16. Он делает глубокий вдох.");
                    Console.ReadLine();
                    scene = 17;
                    break;

                case 17:
                    Console.WriteLine("17. Мальчик смотрит ей в глаза.");
                    Console.ReadLine();
                    scene = 18;
                    break;

                case 18:
                    Console.WriteLine("18. Сердце бьётся всё быстрее.");
                    Console.ReadLine();
                    scene = 19;
                    break;

                case 19:
                    Console.WriteLine("19. Он собирается с мыслями.");
                    Console.ReadLine();
                    scene = 20;
                    break;

                case 20:
                    Console.WriteLine("20. Момент признания.");
                    Console.WriteLine("1 — Сказать прямо");
                    Console.WriteLine("2 — Намекнуть");
                    choice = Console.ReadLine();
                    scene = (choice == "1") ? 100 : 104;
                    break;

                case 100:
                    Console.WriteLine("СЧАСТЛИВАЯ КОНЦОВКА");
                    Console.WriteLine("Она признаётся, что тоже давно любит его.");
                    return;

                case 101:
                    Console.WriteLine("ДРУЖБА");
                    Console.WriteLine("Они остаются друзьями.");
                    return;

                case 102:
                    Console.WriteLine("СОЖАЛЕНИЕ");
                    Console.WriteLine("Он так и не решился подойти.");
                    return;

                case 103:
                    Console.WriteLine("ОЖИДАНИЕ");
                    Console.WriteLine("Он решает признаться в другой день.");
                    return;

                case 104:
                    Console.WriteLine("НЕОПРЕДЕЛЁННОСТЬ");
                    Console.WriteLine("Она просит время подумать.");
                    return;

                case 105:
                    Console.WriteLine("СПОКОЙНЫЙ ОТКАЗ");
                    Console.WriteLine("Она не готова к отношениям.");
                    return;

                case 106:
                    Console.WriteLine("НЕОЖИДАННОСТЬ");
                    Console.WriteLine("Она говорит, что догадывалась.");
                    return;

                case 107:
                    Console.WriteLine("БОЛЕЗНЕННЫЙ ОПЫТ");
                    Console.WriteLine("Ответ оказался не таким, как он ожидал.");
                    return;

                case 108:
                    Console.WriteLine("НАЧАЛО ИСТОРИИ");
                    Console.WriteLine("Это только первый шаг.");
                    return;

                case 109:
                    Console.WriteLine("ТИШИНА");
                    Console.WriteLine("Он так и не сказал главного.");
                    return;

                default:
                    Console.WriteLine("Ошибка сцены.");
                    return;
            }
        }
    }
}