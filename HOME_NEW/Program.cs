// Задача 2: Напишите программу, которая 
// на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

// Console.Write("Введите число А: ");
// int numberA = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите число B: ");
// int numberB = Convert.ToInt32(Console.ReadLine());
// int max = numberA;

// if (numberB > numberA)
// {
//     Console.WriteLine($"a = {numberA}, b = {numberB}, max = {numberB}");
// }
// else{
//     Console.WriteLine($"a = {numberA}, b = {numberB}, max = {numberA}");
// }

// Задача 4: 
// Напишите программу, которая принимает на вход три числа
// и выдаёт максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

// Console.Write("Введите число А: ");
// int numberA = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите число B: ");
// int numberB = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите число C: ");
// int numberC = Convert.ToInt32(Console.ReadLine());

// int max = numberA;

// if(numberB > max) max = numberB;
// if(numberC > max) max = numberC;
// {
//     Console.WriteLine($"{numberA}, {numberB}, {numberC}, max = {max}");
// }
// Задача 6: 
// Напишите программу, которая на вход принимает число и выдаёт, 
// является ли число чётным (делится ли оно на два без остатка).
// 4 -> да
// -3 -> нет
// 7 -> нет

// Console.Write("Введите число: ");
// int number = Convert.ToInt32(Console.ReadLine());

// if(number % 2 == 0)
// {
//     Console.WriteLine($"{number} является четным числом");
// }
// else
// {
//     Console.WriteLine($"{number} НЕ является четным числом");
// }
// Задача 8: 
// Напишите программу, которая на вход принимает число (N), 
// а на выходе показывает все чётные числа от 1 до N.
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

Console.Write("Введите число N: ");
int number = Convert.ToInt32(Console.ReadLine());
int current = 2;

while (current <= number)
{
    Console.Write($"{current} ");
    current+=2;
}
Console.WriteLine();

