using System;

class Program {

    public static void Main(string[] args) {
    
        Circulo x = new Circulo(); // instanciando x
        
        x.SetRaio(2); // valor do raio
        
        double area = x.CalcArea();
        double circ = x.CalcCircunferencia();
        
        Console.WriteLine($"Área do círculo: {area:0.00}");
        Console.WriteLine($"Circunferência do círculo: {circ:0.00}");
    }
 
}

class Circulo {

    private double raio; // valor recebido da classe Main - definido pelo usuário
    double pi = 3.14159;

    public void SetRaio(double v) {
        // teste com o valor do raio
        // os cálculos apenas serão possíveis com raio maior que zero
        if (v > 0) raio = v;
    }

    public double GetRaio() {
        // retorno do valor
        // poderá ser utilizado na classe Main
        return raio;
    }

    public double CalcArea() {
        return (pi * pi) * raio;
    }

    public double CalcCircunferencia() {
        return 2 * pi * raio;
    }

}
