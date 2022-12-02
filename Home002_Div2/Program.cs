//Задача 2: Напишите программу, которая на вход принимает число и выдаёт, 
//является ли число чётным (делится ли оно на два без остатка).
//4 -> да, -3 -> нет, 7 -> нет

Console.WriteLine("start"); // начало

int number = 4; // Определили целое число
int result = number % 2; // вычислениt четных
Console.WriteLine(result); // Вывод результата

Console.WriteLine("end"); // окончание
Console.WriteLine("Введите число: ");
string s = Console.ReadLine();
int n = Convert.ToInt32(s); 
Console.WriteLine(n % 2 == 0 ? "Четное" : "Нечетное");
