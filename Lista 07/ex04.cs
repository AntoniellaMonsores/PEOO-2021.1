using System;

class MainClass {

  public static bool Aprovado(int nota1, int nota2) {

    double media = (nota1 + nota2) / 2;

    if (media >= 60) return true;
    else return false;

  }

  public static void Main(string[] args) {

    double n1, n2;

    n1 = double.Parse(Console.ReadLine());
    n2 = double.Parse(Console.ReadLine()); 

    if (Aprovado(n1, n2))
      Console.WriteLine("Aluno aprovado")
    else
      Console.WriteLine("Aluno reprovado")
      
  }

}
