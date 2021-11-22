using System;

class MainClass {

    public static void Main(string[] args)
    {
        int a1, a2, a3;
        int t1, t2, t3;

        a1 = int.Parse(Console.ReadLine());
        a2 = int.Parse(Console.ReadLine());
        a3 = int.Parse(Console.ReadLine());

        t1 = 2 * (a2 * 1 + a3 * 2);
        t2 = 2 * (a1 * 1 + a3 * 1);
        t3 = 2 * (a1 * 2 + a2 * 1);

        if (t1 > t2) {
            t1 = t2;
        }

        if (t1 > t3) {
            t1 = t3;
        }

        Console.WriteLine(t1);
    }
}
