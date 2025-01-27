using System;

class Program
{
    static void PrintArray(int[] array, int index)
    {
        if (index < 0)
            return;
        Console.WriteLine(array[index]); 
        PrintArray(array, index - 1);
    }
    
    static void Main()
    {
        int[] array = { 1, 2, 3, 4, 5 };
        PrintArray(array, array.Length - 1);
    }
}