using System;

class Gerente : Imposto
{
    //metodo
    public override void valeAlimentacao(double salario)
    {
       Console.WriteLine("Desconte gerente do vale alimentação RS"+(salario * 0.15)); 
    }
}