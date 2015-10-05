using System.Collections.Generic;
using System.Linq;

namespace EscritaPorExtenso.Core
{
    internal class Dezena : IOrdem
    {
        private static readonly Dictionary<int, string> NomeDosAlgarismos = new Dictionary<int, string>()
        {
            {0, ""},
            {1, "dez"}, {2, "vinte"}, {3, "trinta"},
            {4, "quarenta"}, {5, "cinquenta"}, {6, "sessenta"},
            {7, "setenta"}, {8, "oitenta"}, {9, "noventa"},
        };
        private static readonly Dictionary<int, string> NomeDosAlgarismosDaPrimeiraDezena = new Dictionary<int, string>()
        {
            {1, "onze"}, {2, "doze"}, {3, "treze"},
            {4, "quatorze"}, {5, "quinze"}, {6, "dezeseis"},
            {7, "dezesete"}, {8, "dezoito"}, {9, "dezenove"},
        };
        private IOrdem OrdemAnterior { get; set; }
        private int Algarismo { get; set; }

        public Dezena(int algarismo, IOrdem ordemAnterior = null)
        {
            OrdemAnterior = ordemAnterior ?? new Unidade(0);
            Algarismo = algarismo;
        }

        public override string ToString()
        {
            return EhDoCasoEspecialDeDezADezenove
                ? NomeDosAlgarismosDaPrimeiraDezena[OrdemAnterior.Algarismos.First()]
                : LigaOrdens(NomeDosAlgarismos[Algarismo], OrdemAnterior);
        }

        private static string LigaOrdens(string nomeDoAlgarismo, IOrdem ordemAnterior)
        {
            return nomeDoAlgarismo + ((ordemAnterior.Algarismos.First() == 0) ? string.Empty : (" e " + ordemAnterior));
        }

        private bool EhDoCasoEspecialDeDezADezenove
        {
            get { return Algarismo == 1 && Algarismos.Sum() > 1; }
        }

        public int[] Algarismos
        {
            get { return new[] { Algarismo }.Concat(OrdemAnterior.Algarismos).ToArray(); }
        }

    }
}