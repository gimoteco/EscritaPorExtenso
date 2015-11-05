using System;

namespace EscritaPorExtenso.Core
{
    internal class Milhao : Classe
    {
        internal override string Sufixo { get { return EhSingular ? "milhão" : "milhões"; } }

        public Milhao(Ordem ordem, Classe classeAnterior = null)
        {
            Ordem = ordem;
            ClasseAnterior = classeAnterior ?? new Milhar(new Centena(0));
        }

        public override string ToString()
        {
            var ordem = Ordem + " " + Sufixo;
            return LigaClasses(ordem, ClasseAnterior);
        }
    }
}