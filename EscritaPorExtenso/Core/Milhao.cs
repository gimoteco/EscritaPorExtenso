using System;

namespace EscritaPorExtenso.Core
{
    internal class Milhao : Classe
    {
        internal override string Sufixo { get { return EhSingular ? "milhão" : "milhões"; } }

        public Milhao(IOrdem ordem, Classe classeAnterior = null)
        {
            Ordem = ordem;
            ClasseAnterior = classeAnterior ?? new Milhar(new Centena(0));
        }

        public override string ToString()
        {
            var conjuncao = ObterConjuncao(ClasseAnterior);
            return Ordem + " " + Sufixo + (EhClasseAnteriorTudoZero ? String.Empty : (conjuncao + ClasseAnterior));
        }
    }
}