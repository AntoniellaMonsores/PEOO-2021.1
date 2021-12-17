using System;

class MainClass {

  public static bool Aprovado(int nota1, int nota2) {

    int media = (nota1 + nota2) / 2;

    if (media >= 60) return true;
    else return false;

  }

  public static void Main(string[] args) {

    int n1, n2;

    n1 = int.Parse(Console.ReadLine());
    n2 = int.Parse(Console.ReadLine()); 

    if (Aprovado(n1, n2))
      Console.WriteLine("Aluno aprovado");
    else
      Console.WriteLine("Aluno reprovado");
      
  }

}

