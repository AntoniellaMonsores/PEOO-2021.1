using System;
using System.Collections;
using System.Collections.Generic;

class MainClass {

    public static void Main()
    {
        QuadroMedalhas olimpiada = new QuadroMedalhas();

        Pais p1 = new Pais("Suécia ", 7, 4, 4);
        Pais p2 = new Pais("China  ", 7, 4, 2);
        Pais p3 = new Pais("Noruega", 14, 7, 8);
        
        olimpiada.Inserir(p1);
        olimpiada.Inserir(p2);
        olimpiada.Inserir(p3);

        foreach(Pais p in olimpiada.Listar()) { Console.WriteLine(p); }
    }
}

class Pais : IComparable<Pais> {

    string nome;
    int ouro;
    int prata;
    int bronze;


    public Pais(string nome, int ouro, int prata, int bronze) {
        this.nome = nome;
        this.ouro = ouro;
        this.prata = prata;
        this.bronze = bronze;
    }

    public int CompareTo(Pais obj)
    {
        if (this.ouro > obj.ouro) return -1;
        if (this.ouro < obj.ouro) return 1;
        if (this.prata > obj.prata) return -1;
        if (this.prata < obj.prata) return 1;
        if (this.bronze > obj.bronze) return -1;
        if (this.bronze < obj.bronze) return 1;
       
        return this.nome.CompareTo(obj.nome);
    }

    public override string ToString() 
    {
        return $"{nome} - Ouro={ouro:00} - Prata={prata:00} - Bronze={bronze:00}";
    }
}

class QuadroMedalhas {

    Pais[] paises = new Pais[10];
    int nPaises = 0;

    public void Inserir(Pais p)
    {
        paises[nPaises] = p;
        nPaises++;
    }

    public Pais[] Listar()
    {
        Pais[] aux = new Pais[nPaises];
        
        Array.Copy(paises, aux, nPaises);

        return aux;
    }

}
