using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;

namespace EscritorDeNumeroPorExtenso.ClassLibrary
{
    public class Dezena : IOrdem
    {
        private static readonly Dictionary<int, string> _nomeDosAlgarismos = new Dictionary<int, string>()
        {
            {1, "dez"},
            {2, "vinte"},
            {3, "trinta"},
            {4, "quarenta"},
            {5, "cinquenta"},
            {6, "sessenta"},
            {7, "setenta"},
            {8, "oitenta"},
            {9, "noventa"},
        };

        private static readonly Dictionary<int, string> _nomeDosAlgarismosDaPrimeiraDezena = new Dictionary<int, string>()
        {
            {1, "onze"},
            {2, "doze"},
            {3, "treze"},
            {4, "quatorze"},
            {5, "quinze"},
            {6, "dezeseis"},
            {7, "dezesete"},
            {8, "dezoito"},
            {9, "dezenove"},
        };

        public IOrdem OrdemAnterior { get; set; }
        public int Algarismo { get; set; }

        public Dezena(int algarismo, IOrdem ordemAnterior = null)
        {
            OrdemAnterior = ordemAnterior ?? new Unidade(0);
            Algarismo = algarismo;
        }

        public override string ToString()
        {
            return EhDoCasoEspecialDeDezADezenove
                ? _nomeDosAlgarismosDaPrimeiraDezena[OrdemAnterior.Algarismos.First()]
                : LigaOrdens(_nomeDosAlgarismos[Algarismo], OrdemAnterior);
        }

        private static string LigaOrdens(string nomeDoAlgarismo, IOrdem ordemAnterior)
        {
            return nomeDoAlgarismo + ((ordemAnterior.Algarismos.Sum() == 0) ? string.Empty : (" e " + ordemAnterior));
        }

        public bool EhDoCasoEspecialDeDezADezenove
        {
            get { return Algarismo == 1 && Algarismos.Sum() > 1; }
        }

        public int[] Algarismos
        {
            get { return new[] { Algarismo }.Concat(OrdemAnterior.Algarismos).ToArray(); }
        }

    }
}