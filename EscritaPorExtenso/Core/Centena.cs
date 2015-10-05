using System.Collections.Generic;
using System.Linq;

namespace EscritaPorExtenso.Core
{
    internal class Centena : IOrdem
    {
        private static readonly Dictionary<int, string> NomeDosAlgarismos = new Dictionary<int, string>() 
        {
            {0, ""},
            {1, "cem"},  {2, "duzentos"}, {3, "trezentos"},
            {4, "quatrocentos"}, {5, "quinhentos"}, {6, "seiscentos"},
            {7, "setecentos"}, {8, "oitocentos"}, {9, "novecentos"} 
        };
        private int Algarismo { get; set; }
        private IOrdem OrdemAnterior { get; set; }

        public Centena(int algarismo, IOrdem ordemAnterior = null)
        {
            OrdemAnterior = ordemAnterior ?? new Dezena(0, new Unidade(0));
            Algarismo = algarismo;
        }

        public override string ToString()
        {
            return LigaOrdens((EhDoCasoEspecialDaPrimeiraCentena ? "cento" : NomeDosAlgarismos[Algarismo]), OrdemAnterior);
        }

        private bool EhDoCasoEspecialDaPrimeiraCentena
        {
            get { return Algarismo == 1 && Algarismos.Sum() > 1; }
        }

        public int[] Algarismos
        {
            get { return new[] { Algarismo }.Concat(OrdemAnterior.Algarismos).ToArray(); }
        }

        private static string LigaOrdens(string nomeDoAlgarismo, IOrdem ordemAnterior)
        {
            return nomeDoAlgarismo + ((ordemAnterior.Algarismos.Sum() == 0) ? string.Empty : (" e " + ordemAnterior));
        }
    }
}