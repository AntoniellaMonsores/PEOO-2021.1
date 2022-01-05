using System;

class MainClass {

    public static void Main(string[] args) {

        Cinema x = new Cinema();

        Console.WriteLine("Informações da Sessão");

        Console.Write("Dia: ");
        x.d = int.Parse(Console.ReadLine());

        Console.Write("Horário: ");
        x.h = int.Parse(Console.ReadLine());

        Console.WriteLine(x.ValorEntrada());
    }

}

class Cinema {

    public int d;
    public int h;
    
    // base values
    int op1 = 16;
    int op2 = 8;
    int op3 = 20;

    public double ValorEntrada() {

        if (h != 0 && h < 17)
        {
            if (d == 2 || d == 3 || d == 5)
                return op1;
            else if (d == 4)
                return op2;
            else
                return op3;
        }

        else
        {
            if (d == 2 || d == 3 || d == 5)
                return op1 + (50 / 100.0) * op1;
            else if (d == 4)
                return op2 + (50 / 100.0) * op2;
            else
                return op3 + (50 / 100.0) * op3;
        }
        
    }

}
