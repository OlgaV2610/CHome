// Задача 27: Напишите программу, которая принимает на вход число 
// и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12
// Строки использовать нельзя

Console.WriteLine("Введите число N: ");
int i = Convert.ToInt32(Console.ReadLine());
int summa = 0;

while (i > 0)
{
    int number = i % 10;
    i = i / 10;
    summa = summa + number;
}

Console.WriteLine("Cумма цифр в числе равна: " + summa);