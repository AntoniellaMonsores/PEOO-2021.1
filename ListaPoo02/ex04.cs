using System;

class Program {

    public static void Main(string[] args) {

        Cinema a = new Cinema();

        a.SetDia(7);
        a.SetHora(12.5);

        Console.WriteLine(a.ValorEntrada());

    }

}

class Cinema {

    private int dia;
    private double horario;
    
    public void SetDia(int d) {
        if (d > 0 && d <= 7) dia = d;
    }
    
    public void SetHora(double h) {
        if (h >= 0) horario = h;
    }

    public int GetDia() { 
        return dia; 
    }
    
    public double GetHora() { 
        return horario; 
    }

    public double ValorEntrada() {
    
        if (horario > 0 && horario < 17) 
        {
            if (dia == 2 || dia == 3 || dia == 5) { // segunda, terça e quinta
                return 16;
            }
            
            else if (dia == 4) { // quarta
                return 8;
            }
            
            else if (dia == 1 || dia == 6 || dia == 7) { // domingo, sexta e sábado
                return 20;
            }
        }
        
        else 
        {
            if (dia == 2 || dia == 3 || dia == 5) { // segunda, terça e quinta
                return 16 + (50 / 100) * 16;
            }
            
            else if (dia == 4) { // quarta
                return 8 + (50 / 100) * 20;
            }
    
            else if (dia == 1 || dia == 6 || dia == 7) { // domingo, sexta e sábado
                return 20 + (50 / 100) * 20;
            }
        }
        
        return 0;
    }

}
