using System;
using System.Collections.Generic;
using System.Text;

namespace CursoDesignPatterns.Investimentos
{
    public class Conta
    {
        public string Titular { get; private set; }
        public decimal Saldo { get; private set; }

        public Conta(String titular, decimal saldo)
        {
            Titular = titular;
            this.Saldo = saldo;
        }

        public void Deposita(decimal valor)
        {
            this.Saldo += valor;
        }
    }
}
