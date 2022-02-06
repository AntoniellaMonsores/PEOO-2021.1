using System;

class Program
{
    public static void Main()
    {
        Compromisso x = new Compromisso();
        x.Assunto = "a";
        x.Local = "b";
        x.Data = "08/04/2022";
      
        Compromisso y = new Compromisso();
        y.Assunto = "c";
        y.Local = "d";
        y.Data = "22/05/2022";

        Agenda a = new Agenda();
        a.Inserir(x);
        a.Inserir(x);
        a.Inserir(y);
        a.Excluir(x);
    
        foreach (Compromisso c in a.Listar())
            Console.WriteLine(c);

        Console.WriteLine($"Qtd de compromissos: {a.Qtd}");
        /* Teste 01
        Console.WriteLine(x.Assunto);
        Console.WriteLine(x.Local);
        Console.WriteLine(x.Data);
        Console.WriteLine(x);
        */
    }
}

class Agenda
{
    Compromisso[] comps = new Compromisso[0];

    int k = 0;

    public int Qtd { get {return k; } } 

    public void Inserir(Compromisso c)
    {
        Array.Resize(ref comps, k+1); // Resize comps
        comps[k++] = c;
    }

    public void Excluir(Compromisso c)
    {
        int ind = Array.IndexOf(comps, c); // Element to remove

        for (int i = ind; i < comps.Length - 1; i++) 
        {
            comps[i] = comps[i + 1];
        }
        
        Array.Resize(ref comps, k--); // Resize comps
    }

    public Compromisso[] Listar()
    {
        Compromisso[] aux = new Compromisso[k];
        Array.Copy(comps, aux, k);
        return aux;
    }

}

class Compromisso
{
    public string Assunto { get; set; }

    public string Local { get; set; }

    public string Data { get; set; }

    public override string ToString()
    {
        return $"Assunto: {Assunto} - Local: {Local} - Data: {Data}";
    }
}
