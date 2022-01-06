using System;

class Program {

    public static void Main(string[] args {

        

    }

}

class Cinema {

    private int dia;
    private double horario;
    
    public void SetDia(int d) {
        if (d > 0) dia = d;
    }
    
    public void SetHora(int h) {
        if (h >= 0) horario = h;
    }

    public int GetDia() { 
        return dia; 
    }
    
    public double GetHora() { 
        return hora; 
    }

    public int ValorEntrada() {
    
        if (horario > 0 && horario < 17)
        {
            if (dia == 2 || dia == 3 || dia == 5) return 16;
            else if (dia == 4) return 8;
            else return 20;
        }
        
        else 
        {
            if (dia == 2 || dia == 3 || dia == 5) return 16 + (50 / 100) * 16;
            else if (dia == 4) return 8 + (50 / 100) * 20;
            else return 20 + (50 / 100) * 20;
        }
        
    }

}
