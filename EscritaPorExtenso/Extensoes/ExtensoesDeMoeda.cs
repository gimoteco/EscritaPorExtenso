using System;
using EscritaPorExtenso.Moeda;

namespace EscritaPorExtenso
{
    public static class ExtensoesDeMoeda
    {
        public static string PorExtenso(this double valor)
        {
            return new Real(Convert.ToDecimal(valor)).ToString();
        }

        public static string PorExtenso(this int valor)
        {
            return new Real(valor).ToString();
        }

        public static string PorExtenso(this long valor)
        {
            return new Real(valor).ToString();
        }

        public static string PorExtenso(this float valor)
        {
            return new Real(Convert.ToDecimal(valor)).ToString();
        }

        public static string PorExtenso(this decimal valor)
        {
            return new Real(valor).ToString();
        }
    }
}