using System;

class Program
{
    public static void Main()
    {
        Compromisso a = new Compromisso();
        a.Assunto = "a";
        a.Local = "d";
        a.Data = DateTime.Parse("2022-2-7");
      
        Compromisso b = new Compromisso();
        b.Assunto = "b";
        b.Local = "c";
        b.Data = DateTime.Parse("2022-2-6");

        Compromisso c = new Compromisso();
        c.Assunto = "c";
        c.Local = "b";
        c.Data = DateTime.Parse("2022-3-10");

        Agenda newAgenda = new Agenda();

        newAgenda.Inserir(a);
        newAgenda.Inserir(b);
        newAgenda.Inserir(c);
        newAgenda.Excluir(a);

        foreach (Compromisso comp in newAgenda.Listar())
            Console.WriteLine(comp);

        Console.WriteLine($"Qtd de compromissos: {newAgenda.Qtd}");
        Console.WriteLine(newAgenda.Pesquisar(2, 2022).Length);
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
        
        k -= 1;
    }

    public Compromisso[] Listar()
    {
        Compromisso[] aux = new Compromisso[k];
        Array.Copy(comps, aux, k);
        return aux;
    }

    public Compromisso[] Pesquisar(int mes, int ano)
    {
        Compromisso[] aux = new Compromisso[0];
        int n = 0;

        for (int i = 0; i < k; i++)
        {
            if (comps[i].Data.Month == mes && comps[i].Data.Year == ano)
            {   
                Array.Resize(ref aux, n+1); // Resize aux
                aux[n++] = comps[i];
            }
        }

        return aux;
    }

}

class Compromisso
{
    public string Assunto { get; set; }

    public string Local { get; set; }

    public DateTime Data { get; set; }

    public override string ToString()
    {
        return $"Assunto: {Assunto} - Local: {Local} - Data: {Data.Day:00}/{Data.Month:00}/{Data.Year}";
    }
}
