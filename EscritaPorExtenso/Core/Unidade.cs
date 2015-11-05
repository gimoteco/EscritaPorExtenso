using System.Collections.Generic;

namespace EscritaPorExtenso.Core
{
    internal class Unidade : Ordem
    {

        private static readonly Dictionary<int, string> _nomeDosAlgarismos = new Dictionary<int, string>()
        {
                {0, "zero"}, {1, "um"}, {2, "dois"}, {3, "três"},
                {4, "quatro"}, {5, "cinco"}, {6, "seis"},
                {7, "sete"}, {8, "oito"}, {9, "nove"},
        };


        public Unidade(int algarismo, Ordem anterior = null)
        {
            Algarismo = algarismo;
        }

        public override string ToString()
        {
            return _nomeDosAlgarismos[Algarismo];
        }

        public override int[] Algarismos
        {
            get { return new[] { Algarismo }; }
        }
    }
}