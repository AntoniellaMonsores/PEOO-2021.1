using System;

class MainClass {

    public static void Main(string[] args) {

        int[] x = new int[10];
        int n;

        for (int i = 0; i < 10; i++)
        {
            n = int.Parse(Console.ReadLine());

            if (n <= 0)
            {
                n = 1;
            }

            x[i] = n;
        }

        for (int i = 0; i < x.Length; i++)
        {
            Console.WriteLine($"X[{i}] = {x[i]}");
        }

    }

}
