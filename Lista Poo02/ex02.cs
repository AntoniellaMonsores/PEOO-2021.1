using System;

class Program 
{
    public static void Main(string[] args)
    {
        Disciplina x = new Disciplina();

        x.SetNome("Manoela Machado");
        x.SetNota1(60);
        x.SetNota2(45);
        x.SetNota3(55);
        x.SetNota4(60);
        x.SetNotaFinal(65);

        double mediaParcial = x.CalcMediaParcial();  
        double mediaFinal = x.CalcMediaFinal();
        
        Console.WriteLine(x.GetNome());
        Console.WriteLine($"Media Parcial: {mediaParcial}");
        Console.WriteLine($"Media Final: {mediaFinal}");
        
        if (mediaFinal < 60) 
            Console.WriteLine($"Status: Reprovado");
            
        else
            Console.WriteLine($"Status: Aprovado");
    }
}

class Disciplina
{
    private string nome;
    private int nota1;
    private int nota2;
    private int nota3;
    private int nota4;
    private int notaFinal;
    int p1 = 2; // peso notas 1° semestre
    int p2 = 3; // peso notas 2° semestre
    
    public void SetNome(string s) {
        if (s != "") nome = s;
    }
  
    public void SetNota1(int n) {
        if (n >= 0) nota1 = n;
    }
    
    public void SetNota2(int n) {
        if (n >= 0) nota2 = n;
    }
    
    public void SetNota3(int n) {
        if (n >= 0) nota3 = n;
    }
    
    public void SetNota4(int n) {
        if (n >= 0) nota4 = n;
    }
    
    public void SetNotaFinal(int n) {
        if (n >= 0) notaFinal = n;
    }
    
    public string GetNome() {
        return nome;
    }
    
    public int GetNota1() {
        return nota1;
    }
    
    public int GetNota2() {
        return nota2;
    }
    
    public int GetNota3() {
        return nota3;
    }
    
    public int GetNota4() {
        return nota4;
    }
    
    public int GetNotaFinal() {
        return notaFinal;
    }
    
    public double CalcMediaParcial() {
        return (nota1 * p1 + nota2 * p1 + nota3 * p2 + nota4 * p2) / (p1 * 2.0 + p2 * 2.0);
    }
    
    public double CalcMediaFinal() {
        return (notaFinal + ((nota1 * p1 + nota2 * p1 + nota3 * p2 + nota4 * p2) / (p1 * 2.0 + p2 * 2.0))) / 2;
    }
}
