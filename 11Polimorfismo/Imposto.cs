using System;

class Imposto
{
   //Metodos 
   public virtual void valeAlimentacao(double salario)
   {
    Console.WriteLine("Desconte padrão do vale alimentação RS"+(salario * 0.1));
   } 

   public void valetransporte(double salario)
   { 
    Console.WriteLine("Desconte padrão do vale transporte RS"+(salario * 0.06));
   }
}