void Zadacha10()
{
    Random rand = new Random();

    // создал цикл на 10 повторений для удобства тестирования программы.
    for (int i = 0; i < 10; i++)
    {
        int num = rand.Next(100,1000);
        Console.WriteLine("Дано трехзначное число сгенерировнное случайным образом: " + num);

        int secNum = num / 10 % 10;

        Console.WriteLine("Вторая цифра задоного числа " + num + " является: " + secNum);

        Console.WriteLine(); //добавил пробел для удобства чтения.
    }
}

 // Zadacha10();

void Zadacha13()
{
    Console.WriteLine("Введите любое число.");
    int num = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Дано число: " + num);

    if (num > 99)
    {
        int rez = num; //ввел новую переменную rez для выполнения математических операций.
        while (rez > 999)
        {
            rez = rez / 10; 
        }    
        int trdNum = rez % 10;
        Console.WriteLine("Третья цифра по счету с лева введеного числа " + num + " является: " + trdNum);
    }
    else 
    {
        Console.WriteLine("Третьей цифры введеного числа: " + num + " нет!");
    }
}

// Zadacha13();

void Zadacha15()
{
    for (int i = 0; i < 10; i++) // создал цикл на 10 повторений для удобста тестирования программы.
    {
        Random rand = new Random();
        int num = rand.Next(1, 8);
        Console.Write(num + " День недели - ");

        int days( int arg1) // попробовал создать свою функцию.
        {
            int rezult = arg1;
            if (arg1 == 1)
            {
                Console.Write("Понедельник.");
            }

            if (arg1 == 2)
            {
                Console.Write("Вторник.");
            }

            if (arg1 == 3)
            {
                Console.Write("Среда.");
            }

            if (arg1 == 4)
            {
                Console.Write("Четверг.");
            }

            if (arg1 == 5)
            {
                Console.Write("Пятница.");
            }

            if (arg1 == 6)
            {
                Console.Write("Cуббота, выходной день!");
            }

            if (arg1 == 7)
            {
                Console.Write("Воскресенье, выходной день!");
            }
            return rezult;
        }

        int day = days(num);
        Console.WriteLine(); // добавил пробел для удобства чтения результата.
    }    
}

Zadacha15();
