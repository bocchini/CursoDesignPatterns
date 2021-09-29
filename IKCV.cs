namespace CursoDesignPatterns
{
    public class IKCV : TemplateDeImpostoCondicional
    {

        public IKCV() : base() { }

        public IKCV(Imposto outroImposto) : base(outroImposto) { }

        public override bool DeveUsarMaximaTaxacao(Orcamento orcamento)
        {
            return orcamento.Valor > 500 && temItemMarioQueCemReaisNo(orcamento);         
        }

        public override double MaximaTaxacao(Orcamento orcamento)
        {
            return orcamento.Valor * 0.10;
        }

        public override double MinimaTaxacao(Orcamento orcamento)
        {
            return orcamento.Valor * 0.06;
        }

        private bool temItemMarioQueCemReaisNo(Orcamento orcamento)
        {
            foreach (Item item in orcamento.Itens)
            {
                if (item.Valor > 100) return true;
            }
            return false;
        }
    }
}
