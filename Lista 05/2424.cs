using System;

class MainClass {
    
    public static void Main(string[] args) {
        
        string[] c;
        int x, y;
        
        c = Console.ReadLine().Split();
        
        x = Int32.Parse(c[0]);
        y = Int32.Parse(c[1]);
        
        if ((x >= 0 && x <= 432) && (y >= 0 && y <= 468))
            Console.WriteLine("dentro");
        else
            Console.WriteLine("fora"); 
        
    }
    
}
