using System;

class Program
{
    static void Main()
    {
        Console.Title = "Рыцарь Погибшего Солнца";
        int step = 1;
        string choice;
        bool gameOver = false;

        

        Console.WriteLine(" Вы стоите на руинах собора, где когда-то хранился Светоч Вечности...");
        Console.WriteLine("Среди обломков виднеются два предмета. Что возьмёте?");
        Console.WriteLine("1 - Проклятый меч предков\n2 - Древний щит с угасшей руной");
        choice = Console.ReadLine();

        if (choice == "1") Console.WriteLine(" Меж пожирает вашу душу, но дарует силу тьмы.");
        else Console.WriteLine(" Щит мерцает тусклым светом - последний отсвет былой славы.");

        step++;

        Console.WriteLine("\nШаг 2. Из склепа доносится шепот. Исследовать?");
        Console.WriteLine("1 - Войти в склеп\n2 - Обойти стороной");
        choice = Console.ReadLine();

        if (choice == "1")
            Console.WriteLine(" Тени мертвых рыцарей шепчут вам пророчество о грядущей битве.");
        else
            Console.WriteLine("Вы избегаете встречи с призраками, но теряете знание.");

        step++;

        Console.WriteLine("\nШаг 3. На пути - древний мост, охраняемый каменным големом.");
        Console.WriteLine("1 - Сразиться\n2 - Найти обходной путь");
        choice = Console.ReadLine();

        bool hasGolemHeart = false;
        if (choice == "1")
        {
            Console.WriteLine(" Вы побеждаете голема и забираете его каменное сердце.");
            hasGolemHeart = true;
        }
        else Console.WriteLine(" Вы спускаетесь в подземные туннели, теряя время.");

        step++;

        Console.WriteLine("\nШаг 4. Впереди - Заблудший лес, где деревья шепчут ложь.");
        Console.WriteLine("1 - Войти в лес\n2 - Идти вокруг");
        choice = Console.ReadLine();

        bool heardWhispers = choice == "1";
        if (heardWhispers)
            Console.WriteLine(" Голоса леса пытаются сломить вашу волю, но вы слышите правду.");
        else
            Console.WriteLine(" Долгий путь через горы истощает ваши силы.");

        step++;

        Console.WriteLine("\nШаг 5. Ваши раны кровоточат. Остановиться для перевязки?");
        Console.WriteLine("1 - Да\n2 - Продолжить путь");
        choice = Console.ReadLine();

        if (choice == "1")
            Console.WriteLine(" Вы перевязываете раны и готовы к новым испытаниям.");
        else
            Console.WriteLine(" Инфекция распространяется, но вы ближе к цели.");

        step++;

        Console.WriteLine("\nШаг 6. Встречен паладин из вражеского ордена. Предлагает перемирие.");
        Console.WriteLine("1 - Принять помощь\n2 - Сразиться");
        choice = Console.ReadLine();

        bool ally = choice == "1";
        if (ally)
            Console.WriteLine(" Паладин присоединяется к вам, открывая тайные знания.");
        else
            Console.WriteLine(" Вы побеждаете паладина, но тратите много сил.");

        step++;

        Console.WriteLine("\nШаг 7. Преграда - Река Забвения, воды которой стирают память.");
        Console.WriteLine("1 - Переплыть\n2 - Искать брод");
        choice = Console.ReadLine();

        bool crossedRiver = choice == "1";
        if (crossedRiver)
            Console.WriteLine(" Вы теряете часть воспоминаний, но сохраняете цель.");
        else
            Console.WriteLine(" Поиск брода отнимает драгоценное время.");

        step++;

        Console.WriteLine("\nШаг 8. С неба спускаются Варги - слуги тьмы.");
        Console.WriteLine("1 - Атаковать\n2 - Спрятаться в пещере");
        choice = Console.ReadLine();

        if (choice == "1")
            Console.WriteLine(" Вы побеждаете тварей, но привлекаете внимание большего зла.");
        else
            Console.WriteLine(" Вы пережидаете атаку в безопасности.");

        step++;

        Console.
WriteLine("\nШаг 9. Заканчиваются припасы.");
        Console.WriteLine("1 - Охотиться в лесу\n2 - Продолжать голодным");
        choice = Console.ReadLine();

        bool hungry = choice == "2";
        if (hungry)
            Console.WriteLine(" Голод ослабляет вас, но вы не теряете время.");
        else
            Console.WriteLine(" Охота успешна - вы восстановили силы.");

        step++;

        Console.WriteLine("\nШаг 10. Обнаружены руины древнего храма.");
        Console.WriteLine("1 - Исследовать\n2 - Пройти мимо");
        choice = Console.ReadLine();

        bool foundArtifact = false;
        if (choice == "1")
        {
            Console.WriteLine(" Вы находите Древний Амулет - ключ к победе над тьмой!");
            foundArtifact = true;
        }
        else
            Console.WriteLine(" Вы продолжаете путь, не отвлекаясь на руины.");

        step++;

        Console.WriteLine("\nШаг 11. Амулет начинает светиться. Использовать его силу?");
        if (foundArtifact)
        {
            Console.WriteLine("1 - Активировать амулет\n2 - Сохранить силу");
            choice = Console.ReadLine();
            if (choice == "1")
                Console.WriteLine(" Амулет открывает портал в цитадель зла!");
            else
                Console.WriteLine(" Вы сохраняете энергию для решающей битвы.");
        }

        step++;

        Console.WriteLine("\nШаг 12. На горизонте - Черная Цитадель лорда тьмы.");
        Console.WriteLine("1 - Штурмовать ворота\n2 - Искать тайный вход");
        choice = Console.ReadLine();

        bool directAssault = choice == "1";

        step++;

        Console.WriteLine("\nШаг 13. Начинается демонический ливень.");
        Console.WriteLine("1 - Укрыться\n2 - Идти сквозь шторм");
        choice = Console.ReadLine();

        if (choice == "1")
            Console.WriteLine(" Вы пережидаете бурю в разрушенной башне.");
        else
            Console.WriteLine(" Молнии обжигают вас, но вы ближе к цитадели.");

        step++;

        Console.WriteLine("\nШаг 14. Врата цитадели перед вами. Войти?");
        Console.WriteLine("1 - Да\n2 - Отступить");
        choice = Console.ReadLine();

        bool enterCitadel = choice == "1";
        if (enterCitadel)
            Console.WriteLine(" Врата с грохотом открываются. Судьба ждет внутри...");
        else
            Console.WriteLine(" Вы отступаете, но тьма настигнет вас рано или поздно.");

        step++;

        Console.WriteLine("\nШаг 15. ФИНАЛЬНАЯ БИТВА: Ваш выбор определит судьбу мира...");

        // --- КОНЦОВКИ ДАРК ФЭНТЕЗИ ---
        if (enterCitadel && foundArtifact)
        {
            Console.WriteLine(" Концовка 1: ЦЕНА ПОБЕДЫ");
            Console.WriteLine("Вы побеждаете лорда тьмы, но амулет поглощает вашу душу. Вы становитесь новым хранителем тьмы...");
        }
        else if (hasGolemHeart && !enterCitadel)
        {
            Console.WriteLine(" Концовка 2: ВЕЧНЫЙ СТРАЖ");
            Console.WriteLine("Вы используете сердце голема чтобы создать новую крепость, но обрекаете себя на вечную охрану границ тьмы.");
        }
        else if (ally && directAssault)
        {
            Console.WriteLine(" Концовка 3: ЖЕРТВА СОЮЗНИКА");
            Console.WriteLine("Паладин жертвует собой чтобы вы могли нанести решающий удар. Вы побеждаете, но остаетесь в одиночестве.");
        }
        else if (!ally && hungry)
        {
            Console.WriteLine(" Концовка 4: ПРОКЛЯТИЕ ОДИНОЧЕСТВА");
            Console.WriteLine("Ослабленный голодом и ранами, вы падаете перед вратами цитадели. Тьма поглощает ваш разум.");
        }
        else
        {
            Console.WriteLine(" Концовка 5: ТЕНЬ СОМНЕНИЯ");
            Console.WriteLine("Вы отступаете, чтобы сражаться в другой день. Но тьма продолжает расти, и надежда тает...");
        }

        Console.WriteLine("\nДа пребудет с вами сила... или тьма.");
    }
}

