using System;
using System.Collections.Generic;
using System.Text;

namespace CursoDesignPatterns.Investimentos.Requisicoes
{
    enum Formato
    {
        XML,
        CSV,
        PORCENTO
    }

    public class Requisicao
    {
        public Formato Formato { get; private set; }

        public Requisicao(Formato formato)
        {
            this.Formato = formato;
        }

    }

}

