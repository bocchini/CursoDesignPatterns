using System;
using CursoDesignPatterns.Investimentos;

namespace CursoDesignPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            var investe = new Investe();
            investe.Investir();
            */

            /*
            IImposto iss = new ISS();
            IImposto icms = new ICMS();
            IImposto iccc = new ICCC();

            Orcamento orcamento = new Orcamento(500.00);
            Orcamento novoValor = new Orcamento(3001.00);

            CalculadorDeImpostos calculador = new CalculadorDeImpostos();
            calculador.RealizaCalculo(orcamento, iss);
            calculador.RealizaCalculo(orcamento, icms);
            calculador.RealizaCalculo(novoValor, iccc);
            */

            CalculadorDeDescontos calculador = new CalculadorDeDescontos();
            Orcamento orcamento = new Orcamento(500);
            orcamento.AdicionaItem(new Item("Caneta", 250));
            orcamento.AdicionaItem(new Item("Lápis", 250));
            orcamento.AdicionaItem(new Item("Geladeira", 250));
            orcamento.AdicionaItem(new Item("Fogão", 250));
            orcamento.AdicionaItem(new Item("Microondas", 250));
            orcamento.AdicionaItem(new Item("XBOX", 250));


            var desconto = calculador.Calcula(orcamento);
            Console.WriteLine(desconto);
            Console.ReadKey();
        }
    }
}
