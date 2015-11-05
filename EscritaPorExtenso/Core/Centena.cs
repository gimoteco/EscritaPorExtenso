using System.Collections.Generic;
using System.Linq;

namespace EscritaPorExtenso.Core
{
    internal class Centena : Ordem
    {
        private static readonly Dictionary<int, string> NomeDosAlgarismos = new Dictionary<int, string>() 
        {
            {0, ""},
            {1, "cem"},  {2, "duzentos"}, {3, "trezentos"},
            {4, "quatrocentos"}, {5, "quinhentos"}, {6, "seiscentos"},
            {7, "setecentos"}, {8, "oitocentos"}, {9, "novecentos"} 
        };

        public Centena(int algarismo, Ordem ordemAnterior = null)
        {
            OrdemAnterior = ordemAnterior ?? new Dezena(0, new Unidade(0));
            Algarismo = algarismo;
        }

        public override string ToString()
        {
            return LigaOrdens((EhDoCasoEspecial ? "cento" : NomeDosAlgarismos[Algarismo]), OrdemAnterior);
        }

        
    }
}