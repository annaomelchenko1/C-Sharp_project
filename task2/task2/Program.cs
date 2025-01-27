using System;
class Program
{
    static int Ackerman(int n, int m)
    {
        if (n == 0)
            return m + 1;
        else if (m == 0)
            return Ackerman(n - 1, 1);
        else
            return Ackerman(n - 1, Ackerman(n, m - 1));
    }
    
    static void Main()
    {
        int n = 3; 
        int m = 5;
        Console.WriteLine("A(" + n + ", " + m + ") = " + Ackerman(n, m));
    }
}