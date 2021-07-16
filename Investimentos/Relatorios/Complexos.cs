using System;
using System.Collections.Generic;
using System.Globalization;

namespace CursoDesignPatterns.Investimentos.Relatorios
{
    public class Complexos : TemplateRelatorios
    {
        public override void Cabecalho()
        {
            Console.WriteLine("Banco XYZ");
            Console.WriteLine("Avenida Paulista, 1234");
            Console.WriteLine("(11) 1234-5678");
        }

        protected override void Corpo(IList<Conta> contas)
        {
            foreach (Conta conta in contas)
            {
                Console.WriteLine($"Titular: {conta.Titular}, numero da agencia 1255, " +
                    $"numero da conta 12456, Saldo: {conta.Titular}");
            }
           
        }

        public override void Rodape()
        {
            Console.WriteLine($"Email: banco@xyz.com.br, Data: {(DateTime.Now).ToString("D", new CultureInfo("pt-BR"))}");
        }
    }
}


/*
 * 
 * relatórios complexos possuem cabeçalhos que informam o nome do banco, 
 * endereço, telefone, e rodapés que informam e-mail, e a data atual.
 * O relatório complexo exibe titular, agência, número da conta, e saldo.
 * 
 * */