using System;

class MainClass 
{
    public static void Main(string[] args)
    {
        double[] array = new double[100];

        for (int i = 0; i < array.Length; i++)
        {
            array[i] = double.Parse(Console.ReadLine());
        }

        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] <= 10)
            {
                Console.WriteLine($"A[{i}] = {array[i]:0.0}");
            }
        }
    }
}
