using System;

class Viagem {

    public int d; // distância
    public double h; // horas
    public double m; // minutos

    public double VelMedia() {
        return d / h + (m / 60);
    }
    
 }
 
 class MainClass {
 
    public static void Main() {
    
        Viagem x = new Viagem();
        x.d = 200;
        x.h = 2;
        x.m = 30;

        Console.WriteLine($"Velocidade: {x.VelMedia()} km/h");
    }
    
}

