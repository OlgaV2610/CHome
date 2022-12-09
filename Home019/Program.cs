// Напишите программу, которая принимает на вход пятизначное число
// и проверяет, является ли оно палиндромом.

Console.Write("Введите пятизначное число: ");
string s = Console.ReadLine();
int a = Convert.ToInt32(s);

int[] array = new int[5]; // описали массив
for (int i = 4; i >= 0; i--) {
    array[i] = a % 10;
    a = a / 10; 
}
if ((array[0] == array[4]) && (array[1] == array[3]))
{
    Console.Write("Число является палиндромом");
}
else
{
    Console.Write("Число НЕ является палиндромом");
}