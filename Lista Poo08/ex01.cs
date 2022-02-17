using System;
using System.Collections;

class MainClass {

    public static void Main()
    {
        int n;
        int op;

        Console.Write("Número de Alunos: ");

        n = int.Parse(Console.ReadLine());

        Aluno[] lista = new Aluno[n];

        for (int i = 0; i < n; i++)
        {
            Console.WriteLine($"\n{i+1}° Aluno");
            
            Aluno a = new Aluno(); // Instância do objeto

            // Atribuição de valores
            Console.Write("Nome: ");
            a.Nome = Console.ReadLine();
            Console.Write("Matrícula: ");
            a.Matricula = Console.ReadLine();
            Console.Write("Data de nascimento: ");
            a.Nascimento = DateTime.Parse(Console.ReadLine());

            lista[i] = a;
        }

        Console.Write("\nOrdenação - Nome [0] Matrícula [1] Nascimento [2]: ");

        op = int.Parse(Console.ReadLine());

        switch (op)
        {
            case 0:
                Array.Sort(lista);
                break;
            case 1:
                Array.Sort(lista, new AlunoMatriculaComp());
                break;
            case 2:
                Array.Sort(lista, new AlunoNascimentoComp());
                break;
        }

        Console.WriteLine();

        foreach (Aluno i in lista)
            Console.WriteLine(i);
    }
}

class Aluno : IComparable {

    public string Nome { get; set; }
    public string Matricula { get; set; }
    public DateTime Nascimento { get; set; }

    public int CompareTo(object obj) 
    {
        // Comparação de objetos
        return Nome.CompareTo(((Aluno)obj).Nome);
    }

    public override string ToString() 
    {
        return $"Nome: {Nome} - Matrícula: {Matricula} - Nascimento: {Nascimento:dd/MM/yyyy}";
    }
}

class AlunoMatriculaComp : IComparer {

    public int Compare(object x, object y) 
    {
        Aluno a = (Aluno)x;
        Aluno b = (Aluno)y;
        return a.Matricula.CompareTo(b.Matricula);
    }
}

class AlunoNascimentoComp : IComparer {

    public int Compare(object x, object y) 
    {
        Aluno a = (Aluno)x;
        Aluno b = (Aluno)y;
        return b.Nascimento.CompareTo(a.Nascimento);
    }
}
