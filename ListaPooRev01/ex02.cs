using System;

class Program {
    
    public static void Main(string[] args) {
        
        Console.Write("Informe o número de países: ");
        
        int n = int.Parse(Console.Read());
        Pais[] vetor = new Pais[n];
     
        for (int i = 0; i < n; i++)
        {
            string nome;
            double area;
            int habs;
            
            Console.Write($"\nInforme o nome do {i}° país: ");
            nome = Console.Read();
            
            Console.Write($"\nInforme a população do {i}° país: ");
            habs = Console.Read();
            
            Console.Write($"\nInforme a área geográfica do {i}° país em km²: ");
            area = Console.Read();
            
            Pais p = new Pais(nome, habs, area);
            vetor[i] = p;
        }

        int[] h = new int[n];
        double[] a = new double[n];
        
        for (int i = 0; i < n; i++)
        {
            h[i] = vetor[i][1];
            a[i[ = vetor[i][2];
        }
        
        int j = MaiorHabs(h);
        int k = MaiorArea(a);
                
        Console.WriteLine($"Mais populoso: {vetor[j][0]} - vetor[j][1]");
        Console.WriteLine($"Maior área: {vetor[k][0]} - vetor[k][2]");
    }

}

class Pais {

    private nome;
    private int populacao;
    private double area;
    
    public void Pais(string n, int p, double a) {
        if (n.Length > 0) nome = n;
        if (p > 0) populacao = p;
        if (a > 0) area = a;
    }
    
    public int MaiorHabs(int[] h) {
        return vetor.IndexOf(h.Max());
    }

    public int MaiorArea(double[] a) {
        return vetor.IndexOf(a.Max());
    }
}
