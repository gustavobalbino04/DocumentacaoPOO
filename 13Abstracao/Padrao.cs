using System;

abstract class Padrao
{

    //Obrigatorio
    public abstract void taxaemprestimo(double valor);

    //Opcional
    public void calculoPoupanca(double valor, double taxa)
    {
        Console.WriteLine("Ganhos obtidos pela poupança"+(valor * taxa));
    }
}