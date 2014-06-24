using System;
using System.Collections.Generic;

namespace EscritorDeNumeroPorExtenso.ClassLibrary
{
    public class Dezena
    {
        private static readonly Dictionary<int, string> _nomeDosAlgarismos = new Dictionary<int, string>()
        {
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
            {0, "dez"},
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

        public int Algarismo { get; set; }

        public Dezena(int algarismo)
        {
            Algarismo = algarismo;
        }

        public override string ToString()
        {
            return _nomeDosAlgarismos[Algarismo];
        }

        public string Com(Unidade unidade)
        {
            return EhDoCasoEspecialDeDezADezenove
                ? _nomeDosAlgarismosDaPrimeiraDezena[unidade.Algarismo]
                : _nomeDosAlgarismos[Algarismo] + " e " + unidade;
        }

        public bool EhDoCasoEspecialDeDezADezenove
        {
            get { return Algarismo == 1; }
        }
    }
}