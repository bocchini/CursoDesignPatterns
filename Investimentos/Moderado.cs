using System;
using System.Collections.Generic;
using System.Text;

namespace CursoDesignPatterns.Investimentos
{
    class Moderado : IInvestimentos
    {
        private Random random;

        public Moderado()
        {
            this.random = new Random();
        }
        public decimal Calcula(Conta conta)
        {

            if (random.Next(2) == 0)
                return conta.Saldo * 0.025m;
            else
                return conta.Saldo  * 0.007m;
        }
    }
}
