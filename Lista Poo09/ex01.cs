using System;
using System.Collections;

class Program
{

    public static void Main(string[] args)
    {
        Colecao<int> colecao = new Colecao<int>();

        colecao.Add(10);
        colecao.Add(27);
        colecao.Add(31);
        colecao.Add(23);
        colecao.Add(131);
        colecao.Add(101);

        colecao.Remove(31);

        colecao.Sort();

        foreach (int i in colecao)
            Console.WriteLine(i);
    }
}

class Colecao<T> : IEnumerable where T : IComparable
{

    // Tipo genérico
    private T[] vetor = new T[50];
    private int n = 0;

    public void Add(T obj)
    {
        if (n < vetor.Length) vetor[n] = obj;
        n++;
    }

    public void Remove(T obj)
    {
        int index = -1;

        for (int i = 0; i < n; i++) 
        {
            if (vetor[i].Equals(obj)) index = i;
        }

        if (index != -1)
        {
            for (int i = index; i < n - 1; i++)
            {
                vetor[i] = vetor[i + 1];
            }

            n--;
        }
    }

    public void Sort()
    {
        // Depois de "n" todos os valores de "vetor" são nulos
        // O valor padrão de objetos do tipo inteiro é zero
        
        T[] aux = new T[n];

        Array.Copy(vetor, aux, n);
        Array.Sort(aux);

        for (int i = 0; i < n; i++) vetor[i] = aux[i];
    }

    public IEnumerator GetEnumerator()
    {
        // Retornar um enumerador para os elementos inseridos na coleção
        // Não é interessante que os valores nulos sejam percorridos

        T[] aux = new T[n];

        Array.Copy(vetor, aux, n);
        
        return aux.GetEnumerator();
    }
}
