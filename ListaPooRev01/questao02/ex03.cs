using System;

class Carrinho {

    Produto[] prods = new Produto[50];   
    int ind = 0;
    
    public void Inserir(Produto p) {
        prods[ind] = p;
        ++ind;
    }
    
    public Produto[] Listar() {
        return prods[0..ind];
    }
    
    public double Somar() 
    {
        double soma = 0;
        double x;
        
        for (int i = 0; i < auxiliar; i++)
        {
            x = prods[i].Getquantidade() * prods[i].Getpreco();
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
        return $"Descrição: {descricao} - Quantidade: {qtd} - Preço: {preco}";
    }
    
}
