using System.Linq;

namespace EscritaPorExtenso.Core
{
    internal class Milhar : Classe
    {
        internal override string Sufixo { get { return "mil"; } }

        public Milhar(IOrdem ordem, Classe classeAnterior = null)
        {
            Ordem = ordem;
            ClasseAnterior = classeAnterior ?? new PrimeiraClasse(new Centena(0));
        }

        public override string ToString()
        {
            if (EhDoCasoEspecialDoPrimeiroMilhar)
                return LigaClasses(Sufixo, ClasseAnterior);

            return LigaClasses(Ordem + " " + Sufixo, ClasseAnterior);
        }
        
        private string LigaClasses(string ordem, Classe classeAnterior)
        {
            var conjuncao = ObterConjuncao(classeAnterior);
            return ordem + (EhClasseAnteriorTudoZero ? string.Empty : (conjuncao + classeAnterior));
        }

        private bool EhDoCasoEspecialDoPrimeiroMilhar
        {
            get { return Ordem.GetType() == typeof (Unidade) && Ordem.Algarismos.First() == 1; }
        }
    }
}