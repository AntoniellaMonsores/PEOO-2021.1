using System;

class MainClass {
  
    public static void Main(string[] args) {

        int time;
        int speed;
        float liters;

        time = int.Parse(Console.ReadLine());
        speed = int.Parse(Console.ReadLine());

        liters = speed * time;
        liters = liters / 12;

        Console.WriteLine($"{liters:0.000}");

    }

}
