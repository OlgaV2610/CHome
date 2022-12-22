// Задача 41: Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

// 1. Попросить пользователя ввести числа.
// 2. пройтись счетчиком по цифрам
// 3. ссумироватьте, что больше 0.


int[] array = {0, 7, 8, -2, -2};

void PrintArray(int[] array)
{
    int count = array.Length;
    Console.Write($"[");
    for (int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.Write($"]");
    Console.WriteLine();
}

int count = 0;
 
for (int i = 0; i < array.Length; i++)
{
    if (array[i] > 0)
    {
        count++;
    }
}
PrintArray(array);
Console.WriteLine($"Количество элементов больше 0 -> {count}");
