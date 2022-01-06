using System;

class Program {

    public static void Main(string[] args) {

        double d, t, v;
        Viagem x = new Viagem();
        
        x.SetDistancia(100);
        x.SetTempo(1.2);
        
        d = x.GetDistancia();
        t = x.GetTempo();
        v = x.VelocidadeMedia();

        Console.WriteLine($"Distância = {d} km");
        Console.WriteLine($"Tempo Gasto = {(int)t} h e {t % 1 * 60} min");
        Console.WriteLine($"Velocidade Média = {v:0.0} km/h");

    }

}

class Viagem {

    private double distancia;
    private double tempo;
    
    public void SetDistancia(double d) { 
        if (d >= 0) distancia = d; 
    }
    
    public void SetTempo(double t) { 
        if (t >= 0) tempo = t; 
    }
    
    public double GetDistancia() { 
        return distancia; 
    }

    public double GetTempo() { 
        return tempo; 
    }
    
    public double VelocidadeMedia() { 
        return distancia / tempo; 
    }
}
