using System;
using System.Collections.Generic;
using System.Text;

namespace CursoDesignPatterns.Investimentos.Requisicoes
{
    public interface IResposta
    {
        void Responde(Requisicao req, Conta conta);
        IResposta OutraResposta { get; set; }
    }
}
