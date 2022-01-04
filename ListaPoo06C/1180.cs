using System;

class MainClass 
{
    public static void Main(string[] args)
    {
        int n;
        int min;
        int ind;
        string[] a;

        n = int.Parse(Console.ReadLine());
        a = Console.ReadLine().Split();

        min = Int32.Parse(a[0]);
        ind = 0;

        for (int i = 1; i < n; i++)
        {
            if (min > Int32.Parse(a[i]))
            {
                min = Int32.Parse(a[i]);
                ind = i;
            }
        }

        Console.WriteLine($"Menor valor: {min}");
        Console.WriteLine($"Posicao: {ind}");
    }
}
