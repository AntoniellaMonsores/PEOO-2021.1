using System;

class MainClass {

    public static void Main(string[] args)
    {
        double[] a = new double[100];

        for (int i = 0; i < 100; i++)
        {
            a[i] = double.Parse(Console.ReadLine());
        }

        for (int i = 0; i < 100; i++)
        {
            if (a[i] <= 10)
                Console.WriteLine($"A[{i}] = {a[i]:0.0}");
        }
    }
}
