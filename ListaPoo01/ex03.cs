using System;

class Viagem {

    public double d; // distância
    public double h; // horas
    public double m; // minutos

    public double VelMedia() {
        return d / (h + (m / 60));
    }
    
 }
 
 class MainClass {
 
    public static void Main() {
    
        Viagem x = new Viagem();
        x.d = 200;
        x.h = 2;
        x.m = 10;

        Console.WriteLine($"{x.VelMedia():0.00} km/h");
    }
    
}
