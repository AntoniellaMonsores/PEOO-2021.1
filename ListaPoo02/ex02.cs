using System;

class Program 
{
    public static void Main(string[] args)
    {
        Disciplina x = new Disciplina;
        
        x.SetNome("Mia");
        x.SetNota1(85);
        x.SetNota2(90);
        x.SetNota3(81);
        x.SetNota4(82);
        
        double mediaParcial = x.CalcMediaParcial();
        
        if (MediaParcial < 60)
        {
            x.SetNotaFinal(60);
            
            double MediaFinal = x.CalcMediaFinal();
            
            if (MediaFinal < 60) 
            {
                Console.WriteLine($"{Media Parcial: {mediaParcial} - Media Final: {mediaFinal}");
                Console.WriteLine($"Status: Reprovado");
            }
            
            else
            {
                Console.WriteLine($"{Media Parcial: {mediaParcial} - Media Final: {mediaFinal}");
                Console.WriteLine($"Status: Aprovado");
            }
        }
     
        else {
            Console.WriteLine($"{Media Parcial: {mediaParcial}");
            Console.WriteLine($"Status: Aprovado");
        }
        
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
    
    public void SetNome(string s)
    {
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
        return (nota1 + nota2 + nota3 + nota4) / (nota1 * p1 + nota2 * p1 + nota3 * p2 + nota4 * p2);
    }
    
    public double CalcMediaFinal() {
        return (notaFinal + (nota1 + nota2 + nota3 + nota4) / (nota1 * p1 + nota2 * p1 + nota3 * p2 + nota4 * p2)) / 2
    }
}
