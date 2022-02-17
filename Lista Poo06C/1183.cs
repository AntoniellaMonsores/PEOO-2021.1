using System;

class MainClass {

    public static void Main(string[] args)
    {
        string op = Console.ReadLine();
        double[,] m = new double[12,12];

        for (int i = 0; i < 12; i++)
        {
            for (int j = 0; j < 12; j++)
            {
                m[i,j] = double.Parse(Console.ReadLine());
            }
        }    

        double res = 0;
        int row = 1;

        for (int i = 0; i < 12; i++)
        {
            for (int j = row; j < 12; j++) 
            { 
                res = res + m[i,j]; 
            }

            row += 1;
        }    
    
        if (op == "M") res = res / 66.0;
       
        Console.WriteLine($"{res:0.0}");
    }
}
