using System;

class Program {

    public static void Main(string[] args) {
        
        Console.Write("Informe o número de países: ");
        
        int n = int.Parse(Console.ReadLine());
        Pais[] vetor = new Pais[n];

        for (int i = 0; i < vetor.Length; i++)
        {
            Console.Write($"Informe o nome do {i+1}° país: ");
            string nome = Console.ReadLine();
            
            Console.Write($"Informe a população do {i+1}° país: ");
            int habs = int.Parse(Console.ReadLine());
            
            Console.Write($"Informe a área geográfica do {i+1}° país em km²: ");
            double area = double.Parse(Console.ReadLine());
            
            Pais p = new Pais(nome, habs, area);
            vetor[i] = p;
        }

        int[] h = new int[n];
        double[] a = new double[n];

        for (int i = 0; i < n; i++) {
            h[i] = vetor[i].GetPopulacao();
            a[i] = vetor[i].GetArea();
        }

        int ind1 = Pais.MaiorPopulacao(n, h);
        int ind2 = Pais.MaiorArea(n, a);

        string n_max1 = vetor[ind1].GetNome();
        string n_max2 = vetor[ind2].GetNome();
        double = a_max = vetor[ind2].GetArea();
        int p_max = vetor[ind1].GetPopulacao();

        Console.WriteLine($"Mais populoso: {n_max1} - {p_max} habitantes");
        Console.WriteLine($"Maior área: {n_max2} - {a_max}" km²);
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
    
    public static int MaiorPopulacao(int n, int[] h) 
    {
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
    
    public static int MaiorArea(int n, double[] a) 
    {
        double max = 0;
        int ind = 0;
        
        for (int i = 0; i < n; i++) 
        {
            if (max < a[i])
            {
                max = a[i];
                ind = i;
            }
        }
        
        return ind;
    }
}
