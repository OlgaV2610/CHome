// Напишите программу, которая принимает на вход число (N)
// и выдает таблицу кубов чисел от 1 до N.

Console.Write("Введите число n: ");
string s = Console.ReadLine();
int n = Convert.ToInt32(s);

s = s + " -> ";
for(int i = 1; i <= n; i++){
    s = s + (i * i * i) + ", ";
}
Console.Write(s);