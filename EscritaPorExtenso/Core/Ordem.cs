using System;
using System.Linq;

namespace EscritaPorExtenso.Core
{
    internal abstract class Ordem
    {
        protected Ordem OrdemAnterior { get; set; }
        protected int Algarismo { get; set; }

        public virtual int[] Algarismos
        {
            get { return new[] { Algarismo }.Concat(OrdemAnterior.Algarismos).ToArray(); }
        }

        protected static string LigaOrdens(string nomeDoAlgarismo, Ordem ordemAnterior)
        {
            const string conjuncao = " e ";
            var deveColocarConjuncao = ordemAnterior.Algarismo != 0;
            var ordemAnteriorPorExtenso = ((deveColocarConjuncao ? conjuncao : string.Empty) + ordemAnterior);
            var deveConcatenarComOrdemAnterior = (ordemAnterior.Algarismos.Sum() != 0);

            return nomeDoAlgarismo + (deveConcatenarComOrdemAnterior ? ordemAnteriorPorExtenso : string.Empty);
        }

        protected bool EhDoCasoEspecial
        {
            get { return Algarismo == 1 && Algarismos.Sum() > 1; }
        }

    }
}