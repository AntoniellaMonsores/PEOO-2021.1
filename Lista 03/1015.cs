using System;

class MainClass {
    
    public static void Main(string[] args) {
        
        string[] line1;
        string[] line2;
        double x1, y1;
        double x2, y2;

        double distance;

        line1 = Console.ReadLine().Split();
        line2 = Console.ReadLine().Split();

        x1 = Double.Parse(line1[0]);
        y1 = Double.Parse(line1[1]);
        x2 = Double.Parse(line2[0]);
        y2 = Double.Parse(line2[1]);

        distance = Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2);
        distance = Math.Sqrt(distance);

        Console.WriteLine($"{distance:0.0000}");
        
    }
    
}
