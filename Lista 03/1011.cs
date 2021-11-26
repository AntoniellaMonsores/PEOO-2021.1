using System;

class MainClass {

    public static void Main(string[] args) {

        int r;
        double volume;

        r = int.Parse(Console.ReadLine());
        volume = (4 / 3.0) * 3.14159 * Math.Pow(r, 3);

        Console.WriteLine($"VOLUME = {volume:0.000}");

    }
    
}
