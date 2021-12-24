using System;

class Program {

    public static void Main(string[] args) {

        int n;
        double x;
        double y;
        string[] values;

        n = int.Parse(Console.ReadLine());
        
        for (int i = 0; i < n; i++) 
        {
            values = Console.ReadLine().Split();

            x = double.Parse(values[0]);
            y = double.Parse(values[1]);

            if (y == 0) 
                Console.WriteLine("divisao impossivel");
            else
                Console.WriteLine($"{(x / y):0.0}");
        }

    }

}
