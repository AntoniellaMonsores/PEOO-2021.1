using System;

class MainClass {

    public static void Main(string[] args)
    {
        int[] x = new int[10];

        for (int i = 0; i < 10; i++) 
        {
            int k = int.Parse(Console.ReadLine());

            if (k <= 0) { x[i] = 1; }
            else { x[i] = k; }
        }

        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine($"X[{i}] = {x[i]}");
        }
    }
}
