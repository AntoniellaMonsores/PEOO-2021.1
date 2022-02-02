using System;

class Program
{
    public static void Main()
    {
        Equacao eq = new Equacao(1, 2, 0);
        double x1 = 2;
        double x2 = 3;

        Console.WriteLine(eq);
        Console.WriteLine("S = {" + x1 + "," + x2 + "}");
        Console.WriteLine($"Delta = {eq.Delta()}");
    }
}

class Equacao 
{
    private double a, b, c;

    public Equacao(double a, double b, double c)
    {
        if (a != 0) {
            this.a = a;
            this.b = b;
            this.c = c;
        }
    }

    public void SetABC(double a, double b, double c)
    {
        if (a != 0) {
            this.a = a;
            this.b = b;
            this.c = c;
        }    
    }

    public void GetABC(out double a, out double b, out double c)
    {
        a = this.a;
        b = this.b;
        c = this.c;
    }

    public bool RaizesReais(out double x1, out double x2)
    {
        if (Delta() < 0) 
        {
            x1 = 0;
            x2 = 0;

            return false;
        }

        x1 = (-b + Math.Sqrt(Delta())) / (2 * a);
        x2 = (-b - Math.Sqrt(Delta())) / (2 * a);

        return true;
    }

    public double Delta()
    {
        return (b * b) - (4 * a * c);
    }

    public override string ToString()
    {
        return $"a = {a} -- b = {b} -- c = {c}";
    }
}
