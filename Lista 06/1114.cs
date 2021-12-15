using System;

class MainClass {

  public static void Main(string[] args) {

    string password = "2002";
    string typed;

    do {
      typed = Console.ReadLine();

      if (password != typed)
        Console.WriteLine("Senha Invalida");
      else
        Console.WriteLine("Acesso Permitido");
    }

    while (typed != "2002");
  }

}

