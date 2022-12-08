// Напишите программу, которая принимает на вход цифру, обозначающую
// день недели и проверяет, является ли этот день выходным:

Console.Write("Введите число от 1 до 7: ");
string s = Console.ReadLine();
int i = Convert.ToInt32(s);

if(i > 0 && i < 8)
{
    if (i == 6 || i == 7)
    {
        Console.WriteLine("Ура, выходной!!!:))))");
    }
    else 
    {
        Console.WriteLine("Это рабочий день :(");
    }
}   
    else
    {
        Console.WriteLine("Извините, такого дня в неделе не существует.");
    }






