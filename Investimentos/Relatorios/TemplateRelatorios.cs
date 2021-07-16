using System.Collections.Generic;

namespace CursoDesignPatterns.Investimentos.Relatorios
{

    public abstract class TemplateRelatorios
    {
        public void ImprimeRelatorio(IList<Conta> contas)
        {
            Cabecalho();
            Corpo();
            Rodape();
        }

        public abstract void Cabecalho();

        protected abstract void Corpo(IList<Conta> contas);

        public abstract void Rodape();        
    }
}
