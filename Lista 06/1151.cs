using System;

class Program {

    public static void Main(string[] args) {

        int n = int.Parse(Console.ReadLine());
        int a = 0;
        int b = 1;
        int c;

        for (int i = 0; i < n; i++)
        {
            if (i == 0)
                Console.Write($"{a} ");

            else if (i == 1)
                Console.Write($"{b} ");

            else 
            {
                c = a + b;
                a = b;
                b = c;

                if (i < n - 1)
                    Console.Write($"{c} ");
                else
                    Console.WriteLine($"{c}");
            }
        }

    }

}
