using System;
using System.Collections.Generic;
using System.Text;

namespace CursoDesignPatterns.Investimentos
{
    class Conservador : IInvestimentos
    {
        public decimal Calcula(Conta conta)
        {
            return conta.Saldo * 0.008m;
        }
    }
}
