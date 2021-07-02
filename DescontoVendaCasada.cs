using System;
using System.Collections.Generic;
using System.Text;

namespace CursoDesignPatterns
{
    class DescontoVendaCasada : IDesconto
    {
        public IDesconto Proximo { get; set; }

        public double Desconta(Orcamento orcamento)
        {
            if (Existe("Caneta", orcamento) && Existe("Lapis", orcamento))
                return orcamento.Valor * 0.05;
            return Proximo.Desconta(orcamento);
        }

        private bool Existe(String nomeDoItem, Orcamento orcamento)
        {
            foreach (Item item in orcamento.Itens)
            {
                if (item.Nome.Equals(nomeDoItem))
                    return true;
            }
            return false;
        }
    }
}
