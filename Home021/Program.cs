// See https://aka.ms/new-console-template for more information
int ax,ay,bx,by;
string s;
Console.Write("Введите пятизначное число: ");
s = Console.ReadLine();
ax = Convert.ToInt32(s);
Console.Write("Введите пятизначное число: ");
s = Console.ReadLine();
ay = Convert.ToInt32(s);
Console.Write("Введите пятизначное число: ");
s = Console.ReadLine();
bx = Convert.ToInt32(s);
Console.Write("Введите пятизначное число: ");
s = Console.ReadLine();
by = Convert.ToInt32(s);
Console.Write(Math.Sqrt((ax-bx)*(ax-bx)+(ay-by)*(ay-by)));