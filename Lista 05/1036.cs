using System;

class MainClass {
    
    public static void Main(string[] args) {
        
        double a, b, c, rd, r1, r2;
        string[] num;

        num = Console.ReadLine().Split();

        a = Double.Parse(num[0]);
        b = Double.Parse(num[1]);
        c = Double.Parse(num[2]);

        rd = Math.Pow(b, 2) - 4 * a * c;

        if (a == 0 || rd <= 0)
            Console.WriteLine("Impossivel calcular");

        else {
            rd = Math.Sqrt(rd);
            r1 = (-b + rd) / (2 * a);
            r2 = (-b - rd) / (2 * a);

            Console.WriteLine($"R1 = {r1:0.00000}");
            Console.WriteLine($"R2 = {r2:0.00000}");
        }
        
    }

}
