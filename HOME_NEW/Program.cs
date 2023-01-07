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

// Console.Write("Введите число N: ");
// int number = Convert.ToInt32(Console.ReadLine());
// int current = 2;

// while (current <= number)
// {
//     Console.Write($"{current} ");
//     current+=2;
// }
// Console.WriteLine();

// Задача 10: 
// Напишите программу, которая принимает на вход трёхзначное число
// и на выходе показывает вторую цифру этого числа. (без пеобразования типов)
// 456 -> 5
// 782 -> 8
// 918 -> 1

// int Second()
// {
//     int randomNum = new Random().Next(100, 1000);
//     Console.WriteLine($"Your number is {randomNum}");
//     int firstNum = randomNum % 100;
//     int secondNum = firstNum / 10;
//     return secondNum;
// }
// Console.WriteLine($"Second number is {Second()}");

// Задача 13: 
// Напишите программу, которая выводит третью цифру заданного числа
// или сообщает, что третьей цифры нет. (без пеобразования типов)
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

void Three(int number)
{
    int threeNum = number 10;
    return threeNum;  
}

Console.WriteLine("Введите трехзначное число: ");
int userNum = Convert.ToInt32(Console.ReadLine());
int res = Three(userNum);
Console.WriteLine($"{userNum} -> {res}");
// Не решила, вернуться ПРЗЖЕ

// Задача 15: 
// Напишите программу, которая принимает на вход цифру, 
// обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

// void Holiday(int number)
// {
//     if (number > 0 && number < 8 )
//     {
//         if (number == 6 || number == 7)
//         Console.WriteLine("Ура, выходной!");
//         else if (number >= 1 || number <= 5)
//         Console.WriteLine("Увы, это рабочий день!");
//     }
//     else
//     Console.WriteLine("Такого дня не существует");
// }
// Console.WriteLine("Введите число: "); 
// int day = Convert.ToInt32(Console.ReadLine());   
// Holiday(day);

// Задача 19:
// Напишите программу, которая принимает на вход пятизначное число и проверяет, 
// является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

// void Palindromic(int num)
// {
//     if (num >= 10000 && num < 100000)
//     {
//         int firstNum = num / 10000;
//         int fifthNum = num % 10;
//         if (firstNum == fifthNum)
//         {
//             num = num / 10;
//             int secondNum = (num / 100) % 10;
//             int fourthNum = num % 10;
//             if(secondNum == fourthNum)
//             {
//                 Console.WriteLine("Число является палиндромом!");
//             }
//             else Console.WriteLine("Число НЕ является палиндромом!");
//         }
//     }
//     else Console.WriteLine("Число не корректное!");
// }

// Console.WriteLine("Введите пятизначное число: ");
// int num = Convert.ToInt32(Console.ReadLine());
// Palindromic(num);

// void CheckPalindromicNumber(int number)
// {
//     if(number >= 10000 && number < 100000)
//     {
//         int division1 = number / 10000;
//         int remainder1 = number % 10;
 
//             if(division1 == remainder1)
//             {
//                 number = number / 10;
//                 int division2 = (number / 100) % 10;
//                 int remainder2 = number % 10;
//                 if(division2 == remainder2)
//                 {
//                     Console.WriteLine("Это число является палиндромом!");
//                 }     
//             }
//             else Console.WriteLine("Это число НЕ является палиндромом!");
//     }
//     else Console.WriteLine("Вы ввели некорректное число!");
// }
 
// Console.WriteLine("Введите пятизначное число:");
// int number = Convert.ToInt32(Console.ReadLine());
// CheckPalindromicNumber(number);

// void CheckPalindromicNumber(int number)
// {
//     int division1 = number / 10000;
//     int remainder1 = number % 10;
 
//     if(division1 == remainder1)
//     {
//         number = number / 10;
//         int division2 = (number / 100) % 10;
//         int remainder2 = number % 10;
//         if(division2 == remainder2)
//         {
//              Console.WriteLine("Это число является палиндромом!");
//         }     
//     }
//     else Console.WriteLine("Это число НЕ является палиндромом!");
// } 
// Console.WriteLine("Введите пятизначное число:");
// int number = Convert.ToInt32(Console.ReadLine());
// CheckPalindromicNumber(number);





// Задача 21:
// Напишите программу, которая принимает на вход координаты двух точек
// и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

// double Longline(int x1, int y1, int x2, int y2, int z1, int z2)
// {
//     double lengthAB = Math.Sqrt(x2 - x1) * (x2 - x1) + (y2 - y1) * (y2 - y1) + (z2 - z1) * (z2 - z1);
//     return lengthAB;
// }
// Console.WriteLine("Введите х координату точки А: ");
// int xA = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите y координату точки А: ");
// int yA = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите z координату точки А: ");
// int zA = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите х координату точки В: ");
// int xB = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите y координату точки В: ");
// int yB = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите z координату точки В: ");
// int zB = Convert.ToInt32(Console.ReadLine());

// double dist = Longline(xA, yA, zA, xB, yB, zB);
// Console.WriteLine($"Расстояние между А и В = {dist} ");
// Не корректно работает!!!



// Задача23
// Напишите программу, которая принимает на вход число (N)
// и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

// void Qube(int num)
// {
//     int current = 1;
//     while (current <= num)
//     {
//         int res = current * current * current;
//         Console.Write($"{res}, ");
//         current++;
//     }
//     Console.WriteLine($"\b\b.");
// }

// Console.WriteLine("Введите ваше число: ");
// int num = Convert.ToInt32(Console.ReadLine());
// if (num>=1)
// {
//     Console.Write($"{num} -> ");
//     Qube(num);
// }
// else Console.WriteLine("Невозможное число!");

