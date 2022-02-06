using System;

class Program
{
    public static void Main()
    {
        Compromisso a = new Compromisso();
        a.Assunto = "a";
        a.Local = "d";
        a.Data = "08/04/2022";
      
        Compromisso b = new Compromisso();
        b.Assunto = "b";
        b.Local = "c";
        b.Data = "22/05/2022";

        Agenda agenda01 = new Agenda();
        agenda01.Inserir(a);
        agenda01.Inserir(b);
        agenda01.Excluir(a);
    
        foreach (Compromisso c in agenda01.Listar())
            Console.WriteLine(c);

        Console.WriteLine($"Qtd de compromissos: {agenda01.Qtd}");
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
