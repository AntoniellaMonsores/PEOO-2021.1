using System;

class MainClass {

    public static void Main(string[] args)
    {
        int n1, n2;
        int result;

        n1 = int.Parse(Console.ReadLine());
        n2 = int.Parse(Console.ReadLine());

        result = n1 * n2;

        Console.WriteLine($"PROD = {result}");
    }
}
