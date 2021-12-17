using System;

class MainClass {
    
    public static void Main(string[] args)
    {
        double b, a;
        double area;
        double peri;
        double diag;

        Console.WriteLine("Digite a base e a altura do retângulo");
        b = double.Parse(Console.ReadLine());
        a = double.Parse(Console.ReadLine());

        area = b * a;
        peri = 2 * (b + a);
        diag = Math.Sqrt(Math.Pow(b, 2) + Math.Pow(a, 2));

        Console.WriteLine($"\nÁrea = {area:0.00} - Perímetro = {peri:0.00} - Diagonal = {diag:0.00}");
    }
    
}
