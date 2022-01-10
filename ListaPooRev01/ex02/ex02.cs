using System;

class Program {

    public static void Main(string[] args) {

        Apto x = new Apto();
        
        Console.Write("N° de andares: ");
        int and = int.Parse(Console.ReadLine());

        Console.Write("N° de apartamentos por andar: ");
        int apt = int.Parse(Console.ReadLine());

        int[] vetor = new int[and * apt];
        
        x.SetNumAndares(and);
        x.SetNumAptosAndar(apt);
        
        vetor = x.GetNumeros();
        
        Console.WriteLine("\nNumeração dos apartamentos:");
        
        foreach (int apto in vetor) {
            Console.WriteLine(apto);
        }
    }

}

class Apto {

    private int numAndares;
    private int numAptosAndar;
    
    public void SetNumAndares(int i) {
        if (i > 0) numAndares = i;
    }
    
    public void SetNumAptosAndar(int i) {
        if (i > 0) numAptosAndar = i;
    }
    
    public int[] GetNumeros() 
    {
        int[] aptos = new int[numAndares * numAptosAndar];
        
        int ind = 0;

        for (int i = 1; i <= numAndares; i++) 
        {
            for (int j = 1; j <= numAptosAndar; j++) 
                aptos[ind++] = i * 100 + j;
        }
     
        return aptos;
    }

}
