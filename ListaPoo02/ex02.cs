using System;

class Program 
{
    public static void Main(string[] args)
    {
        
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
    
    public int SetNota1() {
        return nota1;
    }
    
    public int SetNota2() {
        return nota2;
    }
    
    public int SetNota3() {
        return nota3;
    }
    
    public int SetNota4() {
        return nota4;
    }
    
    public int SetNotaFinal() {
        return notaFinal;
    }
    
    public double CalcMediaParcial() {
        return (nota1 + nota2 + nota3 + nota4) / nota1 * p1 + nota2 * p1 + nota3 * p2 + nota4 * p2;
    }
}
