using System;

class Pessoa
{
    //atributo 
    private string nome = "gustavo";

    //construtor
    public Pessoa(string nome)
    {
        Console.WriteLine(nome);
        Console.WriteLine(this.nome);
    }
}