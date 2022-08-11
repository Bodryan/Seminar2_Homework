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
        int num1 = num;
        int num2 = num;
        int num3 = num;
        int num4 = num;
        int num5 = num;
        int num6 = num;
        int num7 = num;

        int days( int arg1, int arg2, int arg3, int arg4, int arg5, int arg6, int arg7) // попробовал создать свою функцию.
        {
            int rezult = arg1;
            if (arg1 == 1)
            {
                Console.Write("Понедельник.");
            }

            if (arg2 == 2)
            {
                rezult = arg2;
                Console.Write("Вторник.");
            }

            if (arg3 == 3)
            {
                rezult = arg3;
                Console.Write("Среда.");
            }

            if (arg4 == 4)
            {
                rezult = arg4;
                Console.Write("Четверг.");
            }

            if (arg5 == 5)
            {
                rezult = arg5;
                Console.Write("Пятница.");
            }

            if (arg6 == 6)
            {
                rezult = arg6;
                Console.Write("Cуббота, выходной день!");
            }

            if (arg7 == 7)
            {
                rezult = arg7;
                Console.Write("Воскресенье, выходной день!");
            }
            return rezult;
        }

        int day = days(num1, num2, num3, num4, num5, num6, num7);
        Console.WriteLine(); // добавил пробел для удобства чтения результата.
    }    
}

// Zadacha15();
