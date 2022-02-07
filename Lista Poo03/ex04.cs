using System;

class Program
{
    public static void Main()
    {
        Data a = new Data("12/03/2004");
        Console.WriteLine(a);
    }
}

class Data
{
    private int dia, mes, ano;

    public Data(int dia, int mes, int ano)
    {
        if (dia > 0 && dia <= 30) this.dia = dia;
        if (mes > 0 && mes <= 12) this.mes = mes;
        if (ano >= 0) this.ano = ano;
    }

    public Data(string data)
    {
        dia = int.Parse(data.Substring(0, 2));
        mes = int.Parse(data.Substring(3, 2));
        ano = int.Parse(data.Substring(6, 4));
    }

    public void SetData(int dia, int mes, int ano)
    {
        if (dia > 0 && dia <= 30) this.dia = dia;
        if (mes > 0 && mes <= 12) this.mes = mes;
        if (ano >= 0) this.ano = ano;
    }

    public int GetDia()
    {
        return dia;
    }


    public int GetMes()
    {
        return mes;
    }


    public int GetAno()
    {
        return ano;
    }

    public override string ToString()
    {
        return $"{dia:00}/{mes:00}/{ano:0000}";
    }
}
