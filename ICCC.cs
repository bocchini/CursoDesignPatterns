using System;
using System.Collections.Generic;
using System.Text;

namespace CursoDesignPatterns
{
    public class ICCC : Imposto
    {
        public double Calcula(Orcamento orcamento)
        {
            double valor;
            if (1000 > orcamento.Valor)
            {
                valor = orcamento.Valor * 0.05;
            }
            else if (3000 >= orcamento.Valor)
            {
                valor = orcamento.Valor * 0.07;
            }
            else
            {
                valor = (orcamento.Valor * 0.08) + 30;
            }
            return valor;
        }
    }
}
