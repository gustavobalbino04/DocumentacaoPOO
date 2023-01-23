using System;

class Colaborador : Pessoa
{
    //Atributos
    private double salario;

    public Colaborador(string nome, int idade, double salario)
    {
        this.nome = nome;
        this.idade = idade;
        this.salario = salario;

        mensagemPessoa();
        mensagemcolaborador();
    }

    //Método
    private void mensagemcolaborador()
    {
        Console.WriteLine("Salário: "+salario);
    }

}