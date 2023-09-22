//Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
//2, 3, 7 -> 7
//44 5 78 -> 78
//22 3 9 -> 22
Console.WritheLine("Введите первое число: ");
        double a = Convert.Todouble(Console.ReadLine());

        Console.WritheLine("Введите второе число: ");
        double b = Convert.Todouble(Console.ReadLine());

        Console.WritheLine("Введите третье число: ");
        double с = Convert.Todouble(Console.ReadLine());

        double max = Match.max(a, Match.max,(b,c));

        Console.WritheLine($"Максимальное число: {max}");