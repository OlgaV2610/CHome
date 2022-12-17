// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным 
// и минимальным элементов массива.
// [3 7 22 2 78] -> 76

double[] numbers = {3.1, 7.3, 22.6, 2.5, 78.9};
PrintArray(numbers);
double min = Int32.MaxValue;
double max = Int32.MinValue;

for (int n = 0; n < numbers.Length; n++)
{
    if (numbers[n] > max)
        {
            max = numbers[n];
        }
    if (numbers[n] < min)
        {
            min = numbers[n];
        }
}
Console.WriteLine($"Максимальное значение = {max}, минимальное значение = {min}");
Console.WriteLine($"Разница между максимальным и минимальным значением: {max} - {min} = {max - min}");

void PrintArray(double[] numbers)
{
    Console.Write("[ ");
    for(int i = 0; i < numbers.Length; i++)
        {
            Console.Write(numbers[i] + " ");
        }
    Console.Write("]");
    Console.WriteLine();
}

/* 1. найти max значение
2. найти min значение
3. result = max - min*/