// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");


Imposto objE = new Estagiario();
objE.valeAlimentacao(1000);
objE.valetransporte(1000);
Console.WriteLine("----------------");

Imposto objG = new Gerente();
objG.valeAlimentacao(5000);
objG.valetransporte(5000);
Console.WriteLine("----------------");


Imposto objA = new Atendente();
objA.valeAlimentacao(2000);
objA.valetransporte(2000);