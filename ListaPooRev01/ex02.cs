/* 
Informe o número de países:
Informe o nome do 1o país: 
Informe a população do 1o país: 
Informe a área geográfica do 1o país em km2: 
Informe o nome do 2o país:
Informe a população do 2o país: 
Informe a área geográfica do 2o país em km2:
*/

using System;

class Program {
    
    public static void Main(string[] args) {
        
        
        
    }
    
}

class Pais {

    private nome;
    private int populacao;
    private double area;
    
    public void SetPopulacao(int p) {
        if (p > 0) populacao = p;
    }

    public void SetArea(double a) {
        if (a > 0) area = a;
    }
    
    
}
