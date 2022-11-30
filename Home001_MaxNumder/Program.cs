//Найти максимальное из трех чисел: 2, 3, 7.
//Найти максимальное из трех чисел: 44, 5, 78.
//Найти максимальное из трех чисел: 22, 3, 9.

int a = 22;
int b = 3;
int c = 9;

int max = a;

if (b > max) max = b;
if (c > max) max = c;

Console.Write("max = ");
Console.WriteLine(max);