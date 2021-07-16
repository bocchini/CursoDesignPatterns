using System;
using System.Collections.Generic;
using System.Text;

namespace CursoDesignPatterns.Investimentos.Relatorios
{
    public class Simples : TemplateRelatorios
    {

        public override void Cabecalho()
        {
            Console.WriteLine($"Banco: ASD");
        }

        public override void Rodape()
        {
            Console.WriteLine($"Telefone: 123.123123");
        }

        protected override void Corpo(IList<Conta> contas)
        {
            foreach (Conta c in contas)
            {
                Console.WriteLine($"Titular: {c.Titular}, Saldo: {c.Saldo}");
            }
            
        }
    }
}

/*
 * relatórios simples possuem cabeçalhos e rodapés de uma linha, 
 * apenas com o nome do banco e telefone, respectivamente
 * Além disso, dada uma lista de contas, 
 * um relatório simples apenas imprime titular e saldo da conta.
 * 
 */
