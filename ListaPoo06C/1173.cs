using System;

class MainClass {

    public static void Main(string[] args) {

        int v; // input value
        int x; // array values
        int[] n = new int[10];

        v = int.Parse(Console.ReadLine());

        x = v;
    
        for (int i = 0; i < 10; i++)
        {
            n[i] = x;
            x = x * 2;

            Console.WriteLine($"N[{i}] = {n[i]}");
        }

    }
    
}
