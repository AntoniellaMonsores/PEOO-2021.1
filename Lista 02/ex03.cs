using System;

class MainClass
{
    public static void Main(string[] args)
    {
        int n1, n2;
        int p1 = 2;
        int p2 = 3;

        Console.WriteLine("Digite a nota do primeiro bimestre da disciplina:");
        n1 = int.Parse(Console.ReadLine());

        Console.WriteLine("Digite a nota do segundo bimestre da disciplina:");
        n2 = int.Parse(Console.ReadLine());

        int mediaParcial = (n1 * p1 + n2 * p2) / (p1 + p2);

        Console.WriteLine($"\nMédia parcial = {mediaParcial}");
    }
}
