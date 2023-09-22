//Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
//a = 5; b = 7 -> max = 7
//a = 2 b = 10 -> max = 10
//a = -9 b = -3 -> max = -3
Console.WritheLine("Введите первое число: ");
        double a = Convert.Todouble(Console.ReadLine());

        Console.WritheLine("Введите второе число: ");
        double b = Convert.Todouble(Console.ReadLine());

        double max = Match.max(a, b);

        Console.WritheLine($"Максимальное число: {max}");