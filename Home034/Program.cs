/*  Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
    Напишите программу, которая покажет количество чётных чисел в массиве.
    [345, 897, 568, 234] -> 2 
    
    1.Создать массив рандомным способом. Если числа положит значит исп int. 
    99 > трехзначное число <= 999 (от 100 до 1000).
    2. Если число делится на 2 без остатка, то число четное.
    3. Посчитать сколько всего четных чисел.
    4. Вывести на экран.
*/

Console.Write("Введите размер массива:  ");
int size = Convert.ToInt32(Console.ReadLine());
int[] numbers = new int[size];

FillArrayRandomNumbers(numbers);
Console.Write("");
PrintArray(numbers);

int count = 0;
for (int z = 0; z < numbers.Length; z++) 
{
    if (numbers[z] % 2 == 0)
    {
        count++;
    }
}
Console.WriteLine($"Всего {numbers.Length} чисел, {count} -> чётные");

// выводим случайые трехзначные положительные числа
void FillArrayRandomNumbers(int[] numbers)
{
    for(int i = 0; i < numbers.Length; i++)
    {
        numbers[i] = new Random().Next(100,1000);
    }
}
void PrintArray(int[] numbers) 
{
    Console.Write("[ ");
    for(int i = 0; i < numbers.Length; i++)
    {
        Console.Write(numbers[i] + " ");
    }
    Console.Write("]");
    Console.WriteLine();
}
