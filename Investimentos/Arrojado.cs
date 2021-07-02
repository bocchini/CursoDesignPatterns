using System;
using System.Collections.Generic;
using System.Text;

namespace CursoDesignPatterns.Investimentos
{
    class Arrojado : IInvestimentos
    {
        private Random random;

        public Arrojado()
        {
            this.random = new Random();
        }
        public decimal Calcula(Conta conta)
        {
            var chance = random.Next(10);
            if (chance >= 0 && chance <=1)
                return conta.Saldo * 0.5m;
            else if (chance >= 2 && chance <= 4)
                return conta.Saldo * 0.3m;
            else
                return conta.Saldo * 0.006m;
        }
    }
}
