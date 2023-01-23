using System;

class Pessoa
{

    public double peso;
    public double altura;

    public double obterCalculo()
    {
        return(peso/(altura*altura));
    }

    public string situacao(double imc)
    {
        string retorno; 

        if(imc < 18.5){
            retorno ="Abaixo do peso";
        }else if(imc < 25){
            retorno ="Peso normal";
        }else if(imc <30){
            retorno ="Acima do peso";
        }else if(imc <35){
            retorno="Obesidade 1";
        }else if(imc <40){
            retorno="Obesidade 2";
        }else{
            retorno="Obesidade 3";
        }

        return retorno;
    }


    public void mensagem()
    {
        double obterCalcula = obterCalculo();

        string obterSituacao = situacao(obterCalcula);

        Console.WriteLine("Seu IMC é de "+obterCalcula);
        Console.WriteLine("Sua situação é "+obterSituacao);
    }
}