using System;

class Program {

    public static void Main(string[] args) {
    
        Circulo x = new Circulo();
        
        x.SetRaio(5);
        
        Console.WriteLine($"Área do círculo: {x.CalcArea():0.00}");
        Console.WriteLine($"Circunferência do círculo: {x.CalcCircunferencia():0.00}");
    }
 
}

class Circulo {

    private double raio;
    private double pi;

    public void SetRaio(double v) {
        if (v >= 1) raio = v;
    }
  
    public double GetRaio() {
        return raio;
    }

    public double CalcArea() {
        return (pi * pi) * raio;
    }

    public double CalcCircunferencia() {
        return 2 * pi * raio;
    }

}
