using System;

class Program 
{
    public static void Main()
    {
        Frete a = new Frete(10, 20);

        Console.WriteLine(a);
        Console.WriteLine($"Custo: R${a.CalcFrete():0.00}");
    }
}

class Frete
{
    private double distancia;
    private double peso;

    public Frete(double d, double p) {
        if (d > 0) distancia = d;
        if (p > 0) peso = p;
    }

    public void SetDistancia(double d) {
        if (d > 0) distancia = d;
    }

    public void SetPeso(double p) {
        if (p > 0) peso = p;
    }

    public double GetDistancia() {
        return distancia;
    }

    public double GetPeso() {
        return peso;
    }

    public double CalcFrete() {
        return 0.1 * (peso * distancia);
    }

    public override string ToString() {
        return $"Distância: {distancia} km - Peso: {peso} kg";
    }
}
