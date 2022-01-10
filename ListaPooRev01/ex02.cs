using System;

class Program {

    public static void Main(string[] args) {
        
        Console.Write("Informe o número de países: ");
        
        int n = int.Parse(Console.ReadLine());
        Pais[] vetor = new Pais[n];

        for (int i = 0; i < vetor.Length; i++)
        {
            string nome;
            double area;
            int habs;
            
            Console.Write($"Informe o nome do {i+1}° país: ");
            nome = Console.ReadLine();
            
            Console.Write($"Informe a população do {i+1}° país: ");
            habs = int.Parse(Console.ReadLine());
            
            Console.Write($"Informe a área geográfica do {i+1}° país em km²: ");
            area = double.Parse(Console.ReadLine());
            
            Pais p = new Pais(nome, habs, area);
            vetor[i] = p;
        }

        int[] h = new int[n];
        double[] a = new double[n];

        int ind1 = vetor.MaiorPopulacao(n, h);

        for (int i = 0; i < n; i++) {
            h[i] = vetor[i].GetPopulacao();
            a[i] = vetor[i].GetArea();
        }
        
        Console.WriteLine($"Mais populoso: {vetor[ind1].GetNome()} - {vetor[ind1].GetPopulacao()}");
    }

}

class Pais {

    private string nome;
    private int populacao;
    private double area;
    
    public Pais(string n, int p, double a) {
        if (n.Length > 0) nome = n;
        if (p > 0) populacao = p;
        if (a > 0) area = a;
    }

    public string GetNome() {
        return nome;
    }

    public int GetPopulacao() {
        return populacao;
    }

    public double GetArea() {
        return area;
    }
    
    public int MaiorPopulacao(int n, int[] h) {
        int max = 0;
        int ind = 0;
        
        for (int i = 0; i < n; i++) 
        {
            if (max < h[i])
            {
                max = h[i];
                ind = i;
            }
        }
        
        return ind;
    }
    
}
