using System;

class Program {

    public static void Main(string[] args) {

        double d;
        double t;
        Viagem x = new Viagem();
        
        Console.Write("Distância Percorrida: ");
        d = double.Parse(Console.ReadLine());
        
        Console.Write("Tempo Gasto: ");
        t = double.Parse(Console.ReadLine());
        
        x.SetDistancia(d);
        x.SetTempo(t);
        
        Console.WriteLine($"Velocidade Média: {x.VelocidadeMedia()} km/h");

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
