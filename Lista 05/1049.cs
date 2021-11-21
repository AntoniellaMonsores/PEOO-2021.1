using System;

class MainClass 
{
    public static void Main(string[] args) 
    {
        string w1, w2, w3;

        w1 = Console.ReadLine();
        w2 = Console.ReadLine();
        w3 = Console.ReadLine();

        if (w1 == "vertebrado")
        {
            if (w2 == "ave")
            {
                if (w3 == "carnivoro")
                {
                    Console.WriteLine("aguia");
                }

                else
                {
                    Console.WriteLine("pomba");
                }
            }

            else
            {
                if (w3 == "onivoro")
                {
                    Console.WriteLine("homem");
                }

                else
                {
                    Console.WriteLine("vaca");
                }
            }
        }

        else
        {
            if (w2 == "inseto")
            {
                if (w3 == "hematofago")
                {
                    Console.WriteLine("pulga");
                }

                else
                {
                    Console.WriteLine("lagarta");
                }
            }

            else
            {
                if (w3 == "hematofago")
                {
                    Console.WriteLine("sanguessuga");
                }

                else
                {
                    Console.WriteLine("minhoca");
                }
            }
        }
    }
}
