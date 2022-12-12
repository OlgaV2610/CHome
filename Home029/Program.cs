// Задача 29: Напишите программу, которая задаёт массив из N элементов
// (из диапазона [0-14] ) и выводит на экран десятичное представление числа, 
// записанного в СС по основанию 15
// N: 3 [9, 4, 12] => 2097
// Для проверки можно использовать https://numsys.ru/convert/2097/10/15

int[] CreateArray(int count); // создание массива
{
    return new int[count];
}

void Fill(int[] array) // заполнение числами от 0 до 14.
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = Random.Shared.Next(0, 15);
    }
}

string Print(int[] array)
{
    return String.Join(' ', array); // печать массива
}
int Pow(int a, int b)
{
    int result = 1;
    for (int i = 0; i < b; i++)
    {
        result *= a;
    }
    return result; 
} 

int ToDec(int[] value)
{
    int result = 0;
    int count = value.Length;
    for (int i = 0; i < value.Length; i++)
    {
        result += value[i] * Pow(15, count - 1 - i);
    }
    return result;

}
Console.WriteLine(ToDec(new int[] { 9, 4, 12}));