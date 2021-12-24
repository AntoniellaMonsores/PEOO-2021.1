using System;

class Program {

    public static void Main(string[] args) {

        int n;
        int a = 0;
        int b = 1;
        int c;

        for (int i = 0; i < n; i++)
        {
            if (i == 0)
                Console.Write(a);

            else if (i == 1)
                Console.Write(b);

            else {
                c = a + b;
                a = b;
                b = c;

                Console.WriteLine(c);
            }
            
        }

    }

}
