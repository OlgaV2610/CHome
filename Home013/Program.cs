﻿// Напишите программу, которая выводит третью цифру заданного числа 
// или сообщает, что третьей цифры нет.

int i = 32679;
if (i < 99) Console.WriteLine("Увы, третьей цифры нет");
else 
{
    string s = Convert.ToString(i);
    Console.WriteLine("Третья цифра: "+ s[2]);
}
