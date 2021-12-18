using System;

class Disciplina {
    
    public string disciplina;
    public int n1, n2, n3, n4;
    public int final;

    public int MediaParcial() {
        int peso = 2 * 2 + 3 * 2;
        int soma = n1 * 2 + n2 * 2 + n3 * 3 + n4 * 3;
        return soma / peso;
    }

    public int MediaFinal() {
        int peso = 2 * 2 + 3 * 2;
        int soma = n1 * 2 + n2 * 2 + n3 * 3 + n4 * 3;
        return ((soma / peso) + final) / 2;
    }
}

class MainClass {

    public static void Main() {

        Disciplina x = new Disciplina();

        x.disciplina = "Matemática";
        x.n1 = 60;
        x.n2 = 50;
        x.n3 = 60;
        x.n4 = 45;

        Console.WriteLine($"Disciplina: {x.disciplina}");

        if (x.MediaParcial() >= 60) 
        {
            Console.WriteLine("Situação: Aprovado");
        }

        else 
        {
            x.final = 60;

            if (x.MediaFinal() >= 60)
                Console.WriteLine("Situação: Aprovado");
            else
                Console.WriteLine("Situação: Reprovado");
        }
        
    }

}