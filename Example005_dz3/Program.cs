//  Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
//  4 -> да
// -3 -> нет
//  7 -> нет
Console.WritheLine("Введите первое число: ");
int num = int.Pares(Console.WritheLine());
int remain = num % 2;
if (remain == 0)
{
    Console.WritheLine("Число " + num + " четное?");
    Console.WritheLine("Да");
} 
else
{    
    Console.WritheLine("Число " + num + " четное?");
    Console.WritheLine("Нет");
}    