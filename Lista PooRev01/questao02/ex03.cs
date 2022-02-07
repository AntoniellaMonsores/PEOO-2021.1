using System;

class Program {

    public static void Main(string[] args) {

        Carrinho x = new Carrinho();

        Produto a = new Produto("Bubble Tea", 2, 21.99);
    
        x.Inserir(a);

        Produto[] prods = x.Listar();

        Console.WriteLine("PRODUTOS:");

        foreach (Produto p in prods)
            Console.WriteLine(p);

        Console.WriteLine($"\nVALOR TOTAL: R${x.Somar():0.00}");
        
    }

}

class Carrinho {

    Produto[] prods = new Produto[50];   
    int ind = 0;
    
    public void Inserir(Produto p) {
        prods[ind] = p;
        ++ind;
    }
    
    public Produto[] Listar() {
        Produto[] vetor = new Produto[ind];
        Array.Copy(prods, vetor, ind);
        return vetor;
    }
    
    public double Somar() 
    {
        double soma = 0;
        double x;
        
        for (int i = 0; i < ind; i++)
        {
            x = prods[i].GetQuantidade() * prods[i].GetPreco();
            soma = soma + x;
         }
         
        return soma;
    }

}

class Produto {

    private string descricao;
    private int qtd;
    private double preco;
    
    public Produto(string descricao, int qtd, double preco) {
        if (descricao.Length > 0) this.descricao = descricao;
        if (qtd > 0) this.qtd = qtd;
        if (preco > 0) this.preco = preco;
    }
 
    public int GetQuantidade() {
        return qtd;
    }
    
    public double GetPreco() {
        return preco;
    }
    
    public override string ToString() {
        return $"Descrição - {descricao} | Qtd - {qtd} | Preço Un - R${preco:0.00}";
    }
    
}
