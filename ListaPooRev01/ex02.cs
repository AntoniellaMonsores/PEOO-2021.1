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

        int max_p = 0;
        double max_a = 0;
        int j = 0;
        int k = 0;

        for (int i = 0; i < n; i++) {
            h[i] = vetor[i].GetPopulacao();
            a[i] = vetor[i].GetArea();

            if (max_p < h[i])
            {
                max_p = h[i];
                j = i;
            }

            if (max_a < a[i])
            {
                max_a = a[i];
                k = i;
            }
        }

        Console.WriteLine($"Mais populoso: {vetor[j].GetNome()} - {vetor[j].GetPopulacao()}");
        Console.WriteLine($"Maior área: {vetor[k].GetNome()} - {vetor[k].GetArea()}");
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
    
}
