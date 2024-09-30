using DesafioPOO.Models;
using System;

// TODO: Realizar os testes com as classes Nokia e Iphone


class Program
{
    static void Main(string[] args)
    {
        Nokia nokia = new Nokia("11942881397", "Nokia Preto", "3213213", 64);
        nokia.Ligar();
        nokia.ReceberLigacao();
        nokia.InstalarAplicativo("Instagram");

        Iphone iphone = new Iphone("4820020399", "Iphone 11 Pro", "3829323", 128);
        iphone.Ligar();
        iphone.ReceberLigacao();
        iphone.InstalarAplicativo("Github");
    }
}