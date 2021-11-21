using System;

class MainClass 
{
    public static void Main(string[] args) 
    {
        // Valores de entrada
        string[] valores;
        double a, b, c;

        // Valores de saída
        double tri;
        double cir;
        double tra;
        double qua;
        double ret;

        valores = Console.ReadLine().Split();

        a = Double.Parse(valores[0]);
        b = Double.Parse(valores[1]);
        c = Double.Parse(valores[2]);

        tri = (a * c) / 2;
        cir = 3.14159 * Math.Pow(c, 2);
        tra = ((a + b) * c) / 2;
        qua = b * b;
        ret = a * b;

        Console.WriteLine($"TRIANGULO: {tri:0.000}");
        Console.WriteLine($"CIRCULO: {cir:0.000}");
        Console.WriteLine($"TRAPEZIO: {tra:0.000}");
        Console.WriteLine($"QUADRADO: {qua:0.000}");
        Console.WriteLine($"RETANGULO: {ret:0.000}");
    }
}
