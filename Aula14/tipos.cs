using System;

class Program {

  public static void Main() {

    int x = 5;
    int y = 10;
    string s = "Teste";
    string r = "123";
    Aluno a;
    Professor p = new Professor();
    p.idade = 45;
    p.nome = "Gilbert";
    a.idade = 20;
    a.nome = "Gustavo";

    Console.WriteLine(x + y);
    Console.WriteLine(s + r);

  }

}

struct Aluno {
    public int idade; 
    public string nome;
}

class Professor {
    public int idade;
    public string nome;
}


/* 

Tipo por valor: 
    - a própria variável guarda a informação.
    - variável é alocada na memória stack.
    - struct
    - enum

Tipo por referência:
    - guardada apenas a referência ao valor - endereço de memória.
    - dados alocados na memória heap.
    - string - referência interna (não precisa de new)
    - class - referência externa (precisa de new).

static:
    - chamado com a classe
    - uma informação é passada ao método
        - exceção: ReadLine
    - faz uma operação sem precisar ser em relação àquilo que está armazenado
    - exemplos:
        - WriteLine
        - ToString

non static:
    - chamado com a variável
    - faz uma operação no que a instância está armazenando
    - exemplos:
        - Substring
        - ToString

*/
