using System;

class MainClass {

    public static string FormatarNome(string nome) {

        string[] lista = nome.Split(); // dividindo a string
        string novo = "";              // string formatada
        string cada;                   // cada elemento da lista
 
        for (int i = 0; i < lista.Length; i++)
        {
            cada = lista[i];
            novo += char.ToUpper(cada[0]) + cada.Substring(1) + " ";
        }

        return novo.Remove(novo.Length - 1);
    }

    public static void Main(string[] args) {

        string nome = Console.ReadLine();

        Console.WriteLine(FormatarNome(nome));

    }


}
