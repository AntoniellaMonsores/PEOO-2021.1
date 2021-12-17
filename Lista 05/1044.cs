using System;

class MainClass {
    
    public static void Main(string[] args) {
        
        string[] val;
        int a, b;

        val = Console.ReadLine().Split();
        
        a = Int32.Parse(val[0]);
        b = Int32.Parse(val[1]);

        if (a % b == 0 || b % a == 0)
            Console.WriteLine("Sao Multiplos");
        else
            Console.WriteLine("Nao sao Multiplos");
        
    }
    
}
