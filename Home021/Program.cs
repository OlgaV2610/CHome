// Напишите программу, которая принимает на вход координаты двух точек
// и находит расстояние между ними в 2D пространстве.

int ax,ay,bx,by;
string s;

Console.Write("Введите значение координаты x точки a: ");
s = Console.ReadLine();
ax = Convert.ToInt32(s);
Console.Write("Введите значение координаты у точки a: ");
s = Console.ReadLine();
ay = Convert.ToInt32(s);
Console.Write("Введите значение координаты x точки b: ");
s = Console.ReadLine();
bx = Convert.ToInt32(s);
Console.Write("Введите значение координаты y точки b: ");
s = Console.ReadLine();
by = Convert.ToInt32(s);

Console.Write(Math.Sqrt((ax-bx)*(ax-bx)+(ay-by)*(ay-by)));