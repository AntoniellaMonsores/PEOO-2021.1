using System;

class MainClass {

    public static void Main(string[] args) {

        Cinema x = new Cinema();

        Console.WriteLine("Informações da Sessão");

        Console.Write("Dia: ");
        // for cases as "Segunda" or "segunda-feira"
        x.d = Console.ReadLine().ToLower().Split("-")[0];

        Console.Write("Horário: ");
        x.h = int.Parse(Console.ReadLine());

        Console.WriteLine(x.ValorEntrada());
    }

}

class Cinema {

    public string d;
    public int h;
    
    int op1 = 16;
    int op2 = 8;
    int op3 = 20;

    public double ValorEntrada() {

        if (h != 0 && h < 17)
        {
            if (d == "segunda" || d == "terça" || d == "quinta")
                return op1;
            else if (d == "quarta")
                return op2;
            else
                return op3;
        }

        else
        {
            if (d == "segunda" || d == "terça" || d == "quinta")
                return op1 + (50 / 100.0) * op1;
            else if (d == "quarta")
                return op2 + (50 / 100.0) * op2;
            else
                return op3 + (50 / 100.0) * op3;
        }
        
    }

}
