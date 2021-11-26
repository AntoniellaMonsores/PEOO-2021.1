using System;

class MainClass {

    public static void Main(string[] args) {
      
        double a, b, result;
        double pa = 3.5;
        double pb = 7.5;
    
        a = Double.Parse(Console.ReadLine());
        b = Double.Parse(Console.ReadLine());

        result = (a * pa + b * pb) / (pa + pb);

        Console.WriteLine($"MEDIA = {result:0.00000}");
        
    }

}
