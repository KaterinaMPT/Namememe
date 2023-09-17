string calc;
do
{
    Console.WriteLine("Выберите операцию из 9 доступных:");
    Console.WriteLine("1. Сложение");
    Console.WriteLine("2. Вычитание");
    Console.WriteLine("3. Умножение");
    Console.WriteLine("4. Деление");
    Console.WriteLine("5. Возведение в степень");
    Console.WriteLine("6. Нахождение факториала числа");
    Console.WriteLine("7. Нахождение корня числа");
    Console.WriteLine("8. Нахождение процента от числа");
    Console.WriteLine("9. Выход из программы");
    calc = Console.ReadLine();

    switch (calc)
    {
        case "1":
            double number1, number2;
            Console.WriteLine("Введите первое число");
            double.TryParse(Console.ReadLine(), out number1);
            Console.WriteLine("Введите второе число");
            double.TryParse(Console.ReadLine(), out number2);
            Console.WriteLine("Ваш результат" + (number1 + number2));
            Console.WriteLine();
            Console.WriteLine("Введите операцию");
            calc = Console.ReadLine();
            break;
    }
    switch (calc)
    {
        case "2":
            double number1, number2;
            Console.WriteLine("Введите первое число");
            double.TryParse(Console.ReadLine(), out number1);
            Console.WriteLine("Введите второе число");
            double.TryParse(Console.ReadLine(), out number2);
            Console.WriteLine("Ваш результат" + (number1 - number2));
            Console.WriteLine();
            Console.WriteLine("Введите операцию");
            calc = Console.ReadLine();
            break;
    }
    switch (calc)
    {
        case "3":
            double number1, number2;
            Console.WriteLine("Введите первое число");
            double.TryParse(Console.ReadLine(), out number1);
            Console.WriteLine("Введите второе число");
            double.TryParse(Console.ReadLine(), out number2);
            Console.WriteLine("Ваш результат" + (number1* number2));
            Console.WriteLine();
            Console.WriteLine("Введите операцию");
            calc = Console.ReadLine();
            break;
    }
    switch (calc)
    {
        case "4":
            double number1, number2;
            Console.WriteLine("Введите первое число");
            double.TryParse(Console.ReadLine(), out number1);
            Console.WriteLine("Введите второе число");
            double.TryParse(Console.ReadLine(), out number2);
            if (number2 != 0)
            {
                Console.WriteLine("Ваш результат" + (number1 / number2));
                Console.WriteLine();
                Console.WriteLine("Введите операцию");
                calc = Console.ReadLine();
            }
            else
            {
                Console.WriteLine("На ноль делить нельзя");
                Console.WriteLine();
                Console.WriteLine("Введите операцию");
                calc = Console.ReadLine();
            }
            break;
        case "5":
            Console.WriteLine("Введите первое число: ");
            double.TryParse(Console.ReadLine(), out number1);
            Console.WriteLine("Введите степень, в которую нужно возвести: ");
            double.TryParse(Console.ReadLine(), out number2);
            Console.WriteLine("Ваш результат: " + (Math.Pow(number1, number2)));
            Console.WriteLine("");
            Console.WriteLine("Введите операцию: ");
            calc = Console.ReadLine();
            break;
        case "6":
            number2 = 1;
            Console.WriteLine("Введите первое число: ");
            number1 = Convert.ToDouble(Console.ReadLine());
            if (number1 < 0)
            {
                Console.WriteLine("Не существует факториала отрцательного числа");
                Console.WriteLine("");
                Console.WriteLine("Введите операцию: ");
                calc = Console.ReadLine();
            }
            else if (number1 == 0)
            {
                Console.WriteLine("Ваш результат: " + 1);
                Console.WriteLine("");
                Console.WriteLine("Введите операцию: ");
                calc = Console.ReadLine();
            }
            else
            {
                for (int i = 1; i <= number1; i++)
                {
                    number2 *= i;
                }
                Console.WriteLine("Ваш результат: " + number2);
                Console.WriteLine("");
                Console.WriteLine("Введите операцию: ");
                calc = Console.ReadLine();
            }
            break;
        case "7":
            Console.WriteLine("Введите первое число: ");
            double.TryParse(Console.ReadLine(), out number1);
            Console.WriteLine("Ваш результат: " + Math.Sqrt(number1));
            Console.WriteLine("");
            Console.WriteLine("Введите операцию: ");
            calc = Console.ReadLine();
            break;
        case "8":
            Console.WriteLine("Введите первое число: ");
            double.TryParse(Console.ReadLine(), out number1);
            Console.WriteLine("Введите второе число: ");
            double.TryParse(Console.ReadLine(), out number2);
            Console.WriteLine("Ваш результат: " + ((number2/100) * number1) + "%");
            Console.WriteLine("");
            Console.WriteLine("Введите операцию: ");
            calc = Console.ReadLine();
            break;
        case "9":
            Console.WriteLine("Совершён выход из программы");
            break;
        default:
            Console.WriteLine("Такой операции нет");
            Console.WriteLine("");
            Console.WriteLine("Введите операцию: ");
            calc = Console.ReadLine();
            break;
    }
} while (calc != "9");
