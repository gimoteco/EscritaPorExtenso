using System.Collections.Generic;

namespace EscritorDeNumeroPorExtenso.ClassLibrary
{
    public class Centena
    {
        public static readonly Dictionary<int, string> _nomeDosAlgarismos = new Dictionary<int, string>()
        {
            {1, "cem"},
            {2, "duzentos"},
            {3, "trezentos"},
            {4, "quatrocentos"},
            {5, "quinhentos"},
            {6, "seiscentos"},
            {7, "setecentos"},
            {8, "oitocentos"},
            {9, "novecentos"},
        };

        public int Algarismo { get; set; }

        public Centena(int algarismo)
        {
            Algarismo = algarismo;
        }

        public override string ToString()
        {
            return _nomeDosAlgarismos[Algarismo];
        }
    }
}