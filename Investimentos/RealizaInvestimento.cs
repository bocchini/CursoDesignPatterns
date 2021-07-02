using System;
using System.Collections.Generic;
using System.Text;

namespace CursoDesignPatterns.Investimentos
{
    public class RealizaInvestimento
    {
        public void ValorInvestido(Conta conta, IInvestimentos investimentos)
        {
            var retornoDoInvestimento = investimentos.Calcula(conta);
            conta.Deposita(retornoDoInvestimento);
           
            Console.WriteLine(conta.Saldo.ToString("C"));
        }
    }
}
