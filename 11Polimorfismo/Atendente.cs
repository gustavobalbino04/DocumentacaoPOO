using System;

class Atendente : Imposto
{
    public override void valeAlimentacao(double salario)
    {
       Console.WriteLine("Desconte atendente do vale alimentação RS"+(salario * 0.12)); 
    }
}