using System;

class MainClass {

  public static void Main(string[] args) {

    string password = "2002";
    string typed;

    do {
      typed = Console.ReadLine();

      if (password == typed)
        Console.WriteLIne("Senha Invalida");
      else
        Console.WriteLIne("Acesso Permitido");
    }

    while (typed != 2002);
  }

}
