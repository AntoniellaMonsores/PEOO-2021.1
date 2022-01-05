using System;

class Program {

    public static void Main(string[] args) {
    
        Circulo x = new Circulo();
        
        x.SetRaio(2);
        
        double area = x.CalcArea();
        double circ = x.CalcCircunferencia();

        Console.WriteLine($"Área do círculo: {area:0.00}");
        Console.WriteLine($"Circunferência do círculo: {circ:0.00}");
    }
 
}

class Circulo {

    private double raio;
    double pi = 3.14159;

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
