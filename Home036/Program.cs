/*  Задача 36: Задайте одномерный массив, заполненный случайными числами. 
    Найдите сумму элементов, стоящих на нечётных позициях.
    [3, 7, 23, 12] -> 19
    [-4, -6, 89, 6] -> 0
*/
/*
1. Написать метод создание массива целых чисел.
2. Метод заполнения массива случайными числами от - 10 до 10.
3. Метод вывода массива на экран.
4. Метод опредления нечетных индексов.
5. Метод сложения нечетных индексов.
6. Метод вывода результата на экран.
*/

// 1. Написать метод создание массива. 
int[] CreateArray(int count)
{
    return new int[count];
}
//2. Метод заполнения массива случайными числами от - 10 до 10.
void FillArray(int[]array, int argmin, int argmax)
{
    int size = array.Length;
    for (int index = 0; index < size; index++)
    {
        array[index] = new Random().Next(argmin, argmax);
    }
}
// 3. Метод вывода массива на экран.

void PrintArray(int[]array)
{
    int count = array.Length;
    for (int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

// 4. Метод опредления нечетных индексов массива.


// 5. Метод сложения нечетных индексов.


// 6. Метод вывода результата на экран.

int[] collection = CreateArray(10);
FillArray(collection, -10,10);
PrintArray(collection);














// int[] array = new int[4];
// Random rand = new Random();
// int sum = 0;
// // заполнение и вывод на экр
// void PrintArray(int[] array)
// {
//     Console.Write("[");
//     for(int i = 0; i < array.Length; i++)
//     {
//         array[i] = rand.Next(-10, 10);//Заполняем случайными числами диапозоном от -10 до 10
//         Console.Write($" {array[i]} ");
//     }
//     Console.Write("]");

//     for (int i = 0; i < array.Length; i++)
//     {
//         if (array[i] % 2 == 1)
//         {
//             sum = sum + array[i];
//         }
//     }  
//     Console.WriteLine();
//     Console.WriteLine($"Сумма нечетных позиций = {sum}");
// }
// PrintArray(array);
// Console.WriteLine();




