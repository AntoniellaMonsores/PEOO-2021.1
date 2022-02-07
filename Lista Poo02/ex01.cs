using System;

class Program {

    public static void Main(string[] args) {
    
        Circulo x = new Circulo(); // instanciando x
        
        x.SetRaio(2); // valor do raio
        
        double a = x.CalcArea();
        double c = x.CalcCircunferencia();
        
        Console.WriteLine($"Área: {a:0.00} - Circunferência: {c:0.00}");
    }
 
}

class Circulo {

    private double raio; // valor recebido da classe Main - definido pelo usuário
   
    public void SetRaio(double v) {
        // teste com o valor do raio
        if (v > 0) raio = v;
    }

    public double GetRaio() {
        // retorno do valor
        // poderá ser utilizado na classe Main
        return raio;
    }

    public double CalcArea() {
        return (3.14159 * 3.14159) * raio;
    }

    public double CalcCircunferencia() {
        return 2 * 3.14159 * raio;
    }

}
