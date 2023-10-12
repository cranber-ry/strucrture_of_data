var isValueInput = false;
while (!isValueInput)
{
    Console.WriteLine("Выбирите задание:" +
        "\nЦиклы" +
        "\n1. При помощи цикла for вывести на экран нечетные числа от 1 до 99. При решении используйте операцию инкремента (++)." +
        "\n2. Необходимо вывести на экран числа от 5 до 1. При решении используйте операцию декремента(--)." +
        "\n3. Напишите программу, где пользователь вводит любое целое положительное число. А программа суммирует все числа от 1 до введенного пользователем числа. " +
        "Для ввода числа воспользуйтесь Console.ReadLine." +
        "\n4. Необходимо, чтоб программа выводила на экран вот такую последовательность: 7 14 21 28 35 42 49 56 63 70 77 84 91 98." +
        "\n5. Задание 5. Вывести 10 первых чисел последовательности 0, -5,-10,-15.." +
        "\n6. Составьте программу, выводящую на экран квадраты чисел от 10 до 20 включительно.\n" +
        "\nМассивы:" +
        "\n7. Создайте массив целых чисел. Напишете программу, которая выводит сообщение о том, входит ли заданное число в массив или нет. Пусть число для поиска " +
        "задается с консоли(класс Scanner)." +
        "\n8. Создайте массив целых чисел. Удалите все вхождения заданного числа из массива. Пусть число задается с консоли (класс Scanner). " +
        "Если такого числа нет - выведите сообщения об этом." +
        "\n9. Создайте и заполните массив случайным числами и выведете максимальное, минимальное и среднее значение. Для генерации случайного числа используйте метод Math.random(). " +
        "Пусть будет возможность создавать массив произвольного размера. Пусть размер массива вводится с консоли." +
        "\n10. Создайте 2 массива из 5 чисел. Выведите массивы на консоль в двух отдельных строках. Посчитайте среднее арифметическое элементов каждого массива и сообщите, " +
        "для какого из массивов это значение оказалось больше (либо сообщите, что их средние арифметические равны).\n" +
        "\nДополнительное задание" +
        "\n11. Выведите на экран первые 11 членов последовательности Фибоначчи." +
        "\n12. За каждый месяц банк начисляет к сумме вклада 7% от суммы. Напишите программу, в которую пользователь вводит сумму вклада и количество месяцев. " +
        "А банк вычисляет конечную сумму вклада с учетом начисления процентов за каждый месяц. Для вычисления суммы с учетом процентов используйте цикл for. " +
        "Пусть сумма вклада будет представлять тип float.\n" +
        "\nq. Выход (нажмите \"q\" или \"й\")");
    var str = Console.ReadLine();
    if (str.ToLower() == "q" || str.ToLower() == "й")
    {
        return;
    }

    switch (str)
    {
        case "1":
            Console.WriteLine(new string('=', Console.WindowWidth));

            for (int i = 1; i < 100; i++)
            {
                var evenNumber = i % 2 == 0;
                if (!evenNumber)
                {

                    Console.Write($"{i} ");
                }
            }
            Console.WriteLine();
            Console.WriteLine(new string('=', Console.WindowWidth));
            break;
        case "2":
            Console.WriteLine(new string('=', Console.WindowWidth));
            for (int i = 5; i > 0; i--)
            {
                Console.Write($"{i} ");
            }
            Console.WriteLine();
            Console.WriteLine(new string('=', Console.WindowWidth));
            break;
        case "3":
            var sum = 0;
            var value = 0;
            value = scaner.ReadValid("Введите целое положительное число: ");
            Console.Write("Твой массив: ");
            for (int i = 1; i <= value; i++)
            {
                sum += i;
                Console.Write($"{i} ");
            }
            Console.WriteLine();
            Console.WriteLine(new string('=', Console.WindowWidth));
            Console.WriteLine($"Сумма чисел в диапазоне от 1 до {value} равна {sum}");
            Console.WriteLine(new string('=', Console.WindowWidth));
            break;
        case "4":
            Console.WriteLine(new string('=', Console.WindowWidth));
            for (int i = 7; i < 99; i += 7)
            {
                Console.Write($"{i} ");
            }
            Console.WriteLine();
            Console.WriteLine(new string('=', Console.WindowWidth));
            break;
        case "5":
            while (true)
            {
                var elementOfArray = 5;
                value = scaner.ReadValid("Укажите длину массива: ");
                if (value >= 10)
                {
                    int[] arr = new int[value];
                    Console.Write($"Твой массив с длиной {value} символов: ");
                    for (int i = 0; i < value; i++)
                    {
                        elementOfArray -= 5;
                        arr[i] = elementOfArray;
                        Console.Write(arr[i] + " ");

                    }
                    Console.WriteLine("\n" + new string('=', Console.WindowWidth));
                    Console.Write("Первые десять чисел: ");
                    elementOfArray = 5;
                    arr = new int[value];
                    for (int i = 0; i < 10; i++)
                    {
                        elementOfArray -= 5;
                        arr[i] = elementOfArray;
                        Console.Write(arr[i] + " ");
                    }
                    Console.WriteLine();
                    Console.WriteLine(new string('=', Console.WindowWidth));
                    break;
                }
                else
                {
                    var difference = 10 - value;
                    Console.WriteLine($"Ну что за дела. Не смог ещё {difference} числа/чисел осилить????");
                }
            }
            break;
        case "6":
            Console.WriteLine(new string('=', Console.WindowWidth));
            for (int i = 10; i <= 20; i++)
            {
                var result = 0;
                result = (int)Math.Pow(i, 2);
                Console.WriteLine($"Квадрат числа {i} равен {result}");
            }
            Console.WriteLine(new string('=', Console.WindowWidth));
            break;
        case "7":
            int[] mass = { 1, 2, 4, 8, 16, 32, 64, 128, 256, 512, 1024, 2048, 4096, 8192 };
            Console.WriteLine($"Массив, в котором будем искать число: ");
            foreach (int number in mass)
            {
                Console.Write(number + " ");
            }
            value = scaner.ReadValid("\nВведите число для проверки: ");
            var found = false;
            foreach (int number in mass)
            {
                if (number == value)
                {
                    found = true;
                    break;
                }
            }
            Console.WriteLine(new string('=', Console.WindowWidth));
            if (found)
            {
                Console.WriteLine($"Число {value} найдено в массиве");
            }
            else
            {
                Console.WriteLine($"Число {value} не найдено в массиве");
            }
            Console.WriteLine(new string('=', Console.WindowWidth));
            break;
        case "8":
            Random random = new Random();
            value = scaner.ReadValid("Введите длину массива: ");
            mass = new int[value];
            Console.Write("Полученный массив: ");
            for (int i = 0; i < mass.Length; i++)
            {
                mass[i] = random.Next(0, 10);
                Console.Write($"{mass[i]} ");
            }
            value = scaner.ReadValid("Введите число для удаления: ");
            var numberFound = false;
            var newSize = mass.Length;

            for (int i = 0; i < mass.Length; i++)
            {
                if (mass[i] == value)
                {
                    numberFound = true;
                    newSize--;
                }
            }
            Console.WriteLine(new string('=', Console.WindowWidth));
            if (numberFound)
            {
                int[] newMass = new int[newSize];
                var newIndex = 0;
                for (int i = 0; i < mass.Length; i++)
                {
                    if (mass[i] != value)
                    {
                        newMass[newIndex] = mass[i];
                        newIndex++;
                    }
                }
                mass = newMass;
                Console.WriteLine("Число удалено из массива");
                Console.WriteLine("Массив после удаления: ");
                foreach (int number in mass)
                {
                    Console.Write($"{number} ");
                }
            }
            else
            {
                Console.Write("Число не найдено");
            }

            Console.WriteLine();
            Console.WriteLine(new string('=', Console.WindowWidth));
            break;
        case "9":
            random = new Random();
            value = scaner.ReadValid("Введите длину массива: ");
            mass = new int[value];
            Console.Write("Полученный массив: ");
            for (int i = 0; i < mass.Length; i++)
            {
                mass[i] = random.Next(0, 10);
                Console.Write($"{mass[i]} ");
            }
            var maxNumber = mass[0];
            var minNumber = mass[0];
            decimal averageNumber = 0;
            for (int i = 0; i < mass.Length; i++)
            {
                if (mass[i] > maxNumber)
                {
                    maxNumber = mass[i];
                }

                if (mass[i] < minNumber)
                {
                    minNumber = mass[i];
                }
                averageNumber += mass[i];
            }
            averageNumber = averageNumber / mass.Length;
            Console.WriteLine();
            Console.WriteLine(new string('=', Console.WindowWidth));
            Console.WriteLine($"Максимальный элемент массива равен {maxNumber}\n" +
                $"Минимальный элемент массива равен {minNumber}\n" +
                $"Среднее арифметическое {averageNumber}");
            Console.WriteLine(new string('=', Console.WindowWidth));
            break;
        case "10":
            random = new Random();
            value = scaner.ReadValid("Введите длину первого массива: ");
            mass = new int[value];
            averageNumber = 0;
            Console.Write("Полученный массив: ");
            for (int i = 0; i < mass.Length; i++)
            {
                mass[i] = random.Next(0, 10);
                averageNumber += mass[i];
                Console.Write($"{mass[i]} ");
            }

            value = scaner.ReadValid("\nВведите длину второго массива: ");
            int[] mass2 = new int[value];
            var averageNumber2 = 0;
            Console.Write("Полученный массив: ");
            for (int i = 0; i < mass2.Length; i++)
            {
                mass2[i] = random.Next(0, 10);
                averageNumber2 += mass2[i];
                Console.Write($"{mass2[i]} ");
            }
            Console.WriteLine();
            Console.WriteLine(new string('=', Console.WindowWidth));
            if (averageNumber > averageNumber2)
            {
                Console.WriteLine($"Среднее арифметическое первого массива ({averageNumber}) больше второго ({averageNumber2})");
            }
            else if (averageNumber < averageNumber2)
            {
                Console.WriteLine($"Среднее арифметическое первого массива ({averageNumber}) меньше второго ({averageNumber2})");
            }
            else
            {
                Console.WriteLine($"Среднее арифметическое первого массива ({averageNumber}) и второго ({averageNumber2}) равны");
            }
            Console.WriteLine(new string('=', Console.WindowWidth));
            break;
        case "11":
            mass = new int[11];
            var a = 1;
            var b = 1;
            var c = a + b;
            Console.Write($"{a} {b} {c} ");
            for (int i = 0; i < 8; i++)
            {
                a = b;
                b = c;
                c = a + b;
                Console.Write($"{c} ");
            }
            break;
        case "12":
            float deposit = scaner.ReadValid("Положи в банк деньги: ");
            var month = scaner.ReadValid("Сколько месяцев хочешь подержать: ");
            for (int i = 1; i <= month; i++)
            {
                deposit = (float)(deposit * 0.07 + deposit);
            }
            Console.WriteLine(new string('=', Console.WindowWidth));
            Console.Write($"Сумма вклада через {month} месяцев: {deposit}");
            Console.WriteLine();
            Console.WriteLine(new string('=', Console.WindowWidth));
            break;
        default:
            Console.WriteLine("ОШИБКА ВВОДА!! Введите число");
            break;
    }
}




class scaner
{
    public static int ReadValid(string prompt)
    {
        var number = 0;
        var isValid = false;
        while (!isValid)
        {
            Console.Write(prompt + " ");
            var input = Console.ReadLine();
            if (int.TryParse(input, out number))
            {
                isValid = true;
            }
            else
            {
                Console.WriteLine("ОШИБКА ВВОДА!!");
            }
        }
        return number;
    }
}

