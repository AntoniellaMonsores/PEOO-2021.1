using System;

class MainClass {

  public static double Maior(double x, double y) {

    if (x > y)
      return x;
    else
      return y;

  }
    
  public static void Main(string[] args) {

    double x = double.Parse(Console.ReadLine());
    double y = double.Parse(Console.ReadLine());

    Console.WriteLine(Maior(x, y));

  }
  
}
