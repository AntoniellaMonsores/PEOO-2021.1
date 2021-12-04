using System;

class MainClass {

  public static string Iniciais(string[] nome) {

    string iniciais = "";

    for (int i = 0; i < nome.Length; i++)
    {
      iniciais += nome[i][0] + " ";
    }

    return iniciais.Remove(iniciais.Length - 1);

  }

  public static void Main(string[] args) {

    string[] nome = Console.ReadLine().Split();

    Console.WriteLine(Iniciais(nome));
    
  }

}
