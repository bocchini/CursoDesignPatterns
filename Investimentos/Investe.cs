using System;
using System.Collections.Generic;
using System.Text;

namespace CursoDesignPatterns.Investimentos
{
    public class Investe
    {
        public void Investir()
        {
            IInvestimentos conservador = new Conservador();
            IInvestimentos moderado = new Moderado();
            IInvestimentos arrojado = new Arrojado();

            var conta = new Conta(1000);
            var realizaInvestimento = new RealizaInvestimento();
            Console.WriteLine("Conservador");
            realizaInvestimento.ValorInvestido(conta, conservador);
            Console.WriteLine("Moderado");
            realizaInvestimento.ValorInvestido(conta, moderado);
            Console.WriteLine("Conservador");
            realizaInvestimento.ValorInvestido(conta, arrojado);
        }
    }
}
