using System;

class MainClass {
    public static int largest(int[] arr)
    {
        int max = arr[0];
     
        for (int i = 1; i < arr.Length; i++)
            if (arr[i] > max)
                max = arr[i];
     
        return max;
    }

    public static void Main(string[] args)
    {
        int[] arr = new int[100];

        for (int i = 0; i < 100; i++)
        {
            arr[i] = int.Parse(Console.ReadLine());
        }

        int max = largest(arr);
        Console.WriteLine(max);
        Console.WriteLine(Array.IndexOf(arr, max) + 1);
    }
}
