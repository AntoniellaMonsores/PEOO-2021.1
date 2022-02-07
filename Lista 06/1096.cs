using System;

class MainClass {

  public static void Main(string[] args) {

    int n;
    int c = 0; // coelhos
    int r = 0; // ratos
    int s = 0; // sapos
    double total;
    double per_c;
    double per_r;
    double per_s;
    string[] val;
  
    n = int.Parse(Console.ReadLine());

    for (int i = 0; i < n; i++) 
    {
      val = Console.ReadLine().Split();

      if (val[1] == "C")
        c += Int32.Parse(val[0]);
      else if (val[1] == "R") 
        r += Int32.Parse(val[0]);
      else
        s += Int32.Parse(val[0]);
    }

    total = c + r + s;
    per_c = (c / total) * 100;
    per_r = (r / total) * 100;
    per_s = (s / total) * 100;

    // Total de cobaias
    Console.WriteLine($"Total: {total} cobais");

    // Total de cada tipo
    Console.WriteLine($"Total de coelhos: {c}");
    Console.WriteLine($"Total de ratos: {r}");
    Console.WriteLine($"Total de sapos: {s}");

    // Percentual de cada tipo
    Console.WriteLine($"Percentual de coelhos: {per_c:0.00} %");
    Console.WriteLine($"Percentual de ratos: {per_r:0.00} %");
    Console.WriteLine($"Percentual de sapos: {per_s:0.00} %");
    
  }

}
