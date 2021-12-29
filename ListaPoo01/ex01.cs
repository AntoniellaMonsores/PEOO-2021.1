using System;

class MainClass {

    public static void Main(string[] args) {
        
        Circulo x = new Circulo();
        x.raio = 2;
        x.pi = 3.14159;

        Console.WriteLine($"Área do círculo: {x.CalcArea():0.00}");
        Console.WriteLine($"Circunferência do círculo: {x.CalcCircunferencia():0.00}");
        
    }
    
}

class Circulo {

    public double raio;
    public double pi;

    public double CalcArea() {
        return (pi * pi) * raio;
    }

    public double CalcCircunferencia() {
        return 2 * pi * raio;
    }

}
