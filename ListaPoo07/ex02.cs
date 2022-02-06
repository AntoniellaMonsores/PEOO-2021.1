using System;

class Program 
{
    public static void Main()
    {
        Frete x = new Frete();
        x.Distancia = 25;
        x.Peso = 20;

        Console.WriteLine($"{x.Distancia} km");
        Console.WriteLine($"{x.Peso} kg");
        Console.WriteLine($"R$ {x.ValorFrete:0.00}");
        Console.WriteLine(x);
    }
}

class Frete
{
    private double distancia;
    private double peso;

    public double Distancia
    {
        get { return distancia; }
        set { if (value > 0) distancia = value; }
    }

    public double Peso
    {
        get { return peso; }
        set { if (value > 0) peso = value; }
    }

    public double ValorFrete
    {
        get { return 0.1 * peso * distancia; }
    }

    public override string ToString()
    {
        return $"Distância: {distancia} km - Peso: {peso} kg";
    }
}
