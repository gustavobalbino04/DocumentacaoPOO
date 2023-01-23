using System;

class PessoaFisica : Padrao
{
    //Metodo Obrigatorio 
    public override void taxaemprestimo(double valor)
    {
        Console.WriteLine("Taxa de emprestimo para Pessoa Fisica"+(valor * 0.1));
    }
}