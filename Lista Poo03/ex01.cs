using System;

class Program
{
    public static void Main(string[] args)
    {
        Retangulo x = new Retangulo(10, -12);
        Retangulo y = new Retangulo(10, 12);

        Console.WriteLine(x);
        Console.WriteLine($"Área: {x.CalcArea()}");
        Console.WriteLine($"Diagonal: {x.CalcDiagonal()}");

        Console.WriteLine(y);
        Console.WriteLine($"Área: {y.CalcArea()}");
        Console.WriteLine($"Diagonal: {y.CalcDiagonal()}");
    }
}

class Retangulo
{
    private double b; // Base
    private double h; // Altura

    // Set : validação dos valores
    // Get : retorno dos valores

    public Retangulo(double b, double h) { // Construtor
        if (b > 0) this.b = b;
        if (h > 0) this.h = h;
    }

    public void SetBase(double b) {
        if (b > 0) this.b = b;
    }

    public void SetAltura(double h) {
        if (h > 0) this.h = h;
    }

    public double GetBase() {
        return b;
    }

    public double GetAltura() {
        return h;
    }

    public double CalcArea() { 
        // A = b * h
        return b * h;
    }

    public double CalcDiagonal() { 
        // d² = b² + h²
        return Math.Sqrt(Math.Pow(2, b) + Math.Pow(2, h));
    }

    public override string ToString() {
        return $"Base: {b} - Altura: {h}";
    }
}
