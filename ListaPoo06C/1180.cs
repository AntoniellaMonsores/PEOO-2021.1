using System;

class MainClass 
{
    public static void Main(string[] args)
    {
        int n;
        int min;
        int[] array;
        string[] e;

        n = int.Parse(Console.ReadLine());
        e = Console.ReadLine().Split();

        array = new int[n];
        
        for (int i = 0; i < n; i++)
        {
            array[i] = Int32.Parse(e[i]);
        }

        min = array.Min();

        Console.WriteLine($"Menor valor: {min}");
        Console.WriteLine($"{array.IndexOf(min)}");
    }
}
