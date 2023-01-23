using System;

class PessoaJuridica : Padrao
{
    //Metodo Obrigatorio 
    public override void taxaemprestimo(double valor)
    {
        Console.WriteLine("Taxa de emprestimo para Pessoa Juridica"+(valor * 0.20));
    }
}