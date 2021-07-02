using System;
using System.Collections.Generic;
using System.Text;

namespace CursoDesignPatterns.Investimentos.Requisicoes
{
    class RespostaEmCSV : IResposta
    {
        public IResposta OutraResposta { get; set; }

        public void Responde(Requisicao req, Conta conta)
        {
            if (req.Formato == Formato.CSV)
            {
                Console.WriteLine(conta.Titular + ";" + conta.Saldo);
            }
            else
            {
                OutraResposta.Responde(req, conta);
            }
        }
    }
}
