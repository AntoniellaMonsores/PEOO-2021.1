using System;

class MainClass {
    public static void Main(string[] args)
    {
        string[] t;
        int t1, t2;
        int t3, t4;
        
        int devices;

        t = Console.ReadLine().Split();

        t1 = Int32.Parse(t[0]);
        t2 = Int32.Parse(t[1]);
        t3 = Int32.Parse(t[2]);
        t4 = Int32.Parse(t[3]);

        devices = (t1 + t2 + t3 + t4) - 3;
        Console.WriteLine(devices);
    }
}
