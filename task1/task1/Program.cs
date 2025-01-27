using System;
class Program
{
    static void PrintNumbers(int current, int N)
    {
        if (current > N)
            return;
        Console.WriteLine(current);
        PrintNumbers(current + 1, N);
    }
    
    static void Main()
    {
        int M = 5;
        int N = 10; 
        PrintNumbers(M, N);
    }
}