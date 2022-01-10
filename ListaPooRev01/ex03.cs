using System;

class Program {

    public static void Main(string[] args) {

        Apto x = new Apto();
        
        Console.Write("Número de andares: ");
        int and = int.Parse(Console.ReadLine());
        
        Console.Write("Números de apartamentos por andar: ");
        int apt = int.Parse(Console.ReadLine());

        int[] vetor = new int[and * apt];
        
        x.SetNumAndares(and);
        x.SetNumAptosAndar(apt);
        
        vetor = x.GetNumeros();
        
        Console.WriteLine("Apartamentos:");
        
        foreach (a in vetor) {
            Console.WriteLine(a);
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
    
    public int GetNumeros() 
    {
        int[] aptos = new int[numAndares * numAptosAndar];
        
        for (int i = 0; i < numAndares; i++) {
            for (int j = 0; j < numAptosAndar; j++) {
                aptos[i] = numAndares[i] * 100 + j;
            }
        }
     
        return aptos;
    }

}
