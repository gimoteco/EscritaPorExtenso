using System;
using System.Collections.Generic;

namespace EscritorDeNumeroPorExtenso.ClassLibrary
{
    public class Unidade
    {
        public int Algarismo { get; set; }

        private static readonly Dictionary<int, string> _nomeDosAlgarismos = new Dictionary<int, string>()
        {
                {1, "um"}, {2, "dois"}, {3, "três"},
                {4, "quatro"}, {5, "cinco"}, {6, "seis"},
                {7, "sete"}, {8, "oito"}, {9, "nove"},
        };


        public Unidade(int algarismo)
        {
            Algarismo = algarismo;
        }

        public override string ToString()
        {
            return _nomeDosAlgarismos[Algarismo];
        }
    }
}