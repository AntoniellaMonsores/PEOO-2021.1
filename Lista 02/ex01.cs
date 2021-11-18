using System;

class MainClass
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Digite seu primeiro nome:");
        
        string nome = Console.ReadLine();
        Console.WriteLine($"\nBem vindo ao C#, {nome}");
    }
}
