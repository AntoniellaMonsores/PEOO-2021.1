using System;

class MainClass 
{   
    public static void Main(string[] args) 
    {       
        Console.WriteLine("Digite seu nome completo:");

        string nomeCompleto = Console.ReadLine();
        
        Console.WriteLine($"\nBem vindo ao C#, {nomeCompleto.Substring(0, nomeCompleto.IndexOf(" "))}");
    }
}
