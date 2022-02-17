using System;

class MainClass {

    public static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        int[] x = new int[n];

        string[] input = Console.ReadLine().Split();

        for (int i = 0; i < n; i++) { x[i] = int.Parse(input[i]); }
        
        int ind = 0;
        int min = x[ind];

        for (int i = 1; i < n; i++)
        {
            if (min > x[i])
            {
                min = x[i];
                ind = i;
            }
        }

        Console.WriteLine($"Menor valor: {min}");
        Console.WriteLine($"Posicao: {ind}");
    }
}
