using System;

class MainClass {

    public static void Main(string[] args)
    {
        int[] n = new int[10];
        int v = int.Parse(Console.ReadLine());

        n[0] = v;

        for (int i = 1; i < 10; i++)
        {
            n[i] = n[i-1] * 2;
        }

        for (int i = 0; i < 10; i++) 
        {
            Console.WriteLine($"N[{i}] = {n[i]}");
        }
    }
}
