public class MyLibrary
{   // создание массива
    public static int[] CreateArray(int count) 
    {
        return new int[count];
    }
    // заполнение числами от 0 до 14.       
    public static void Fill(int[] array)
    {
        for (int i = 0; i < array.Length; i++)
        {
        array[i] = Random.Shared.Next(0, 15);
        }
    } 
    // печать массива
    public static string Print(int[] array)
    {
        return String.Join(' ', array); 
    }
    public static int Pow(int a, int b)
    {
        int result = 1;
        for (int i = 0; i < b; i++)
        {
            result *= a;
        }
        return result; 
    }
    public static int ToDec(int[] value)
    {
        int result = 0;
        int count = value.Length;
        for (int i = 0; i < count; i++)
        {
            result += value[i] * Pow(15, count - 1 - i);
        }
        return result;
    }
}