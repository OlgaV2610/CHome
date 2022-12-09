// Напишите программу, которая принимает на вход трехзначное число 
// и на выходе показывает вторую этого числа.

Console.Write("Введите трехзначное число: ");
string s = Console.ReadLine();
int i = Convert.ToInt32(s);

if(i > 99 && i <= 999)
{
    i = i / 10;
    i = i - (i / 10)*10;
    Console.WriteLine(i);
}




