using System;

class MainClass
{

    public static void Main(string[] args)
    {
        string[] input;
        int c, n, t;

        input = Console.ReadLine().Split();
        c = Int32.Parse(input[0]);
        n = Int32.Parse(input[1]);

        t = c % n;

        Console.WriteLine(t);
    }
}
