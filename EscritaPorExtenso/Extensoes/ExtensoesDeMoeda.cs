using System;

namespace EscritaPorExtenso.Moeda
{
    public static class ExtensoesDeMoeda
    {
        public static string PorExtensoDeReal(this double valor)
        {
            return new Real(Convert.ToDecimal(valor)).ToString();
        }

        public static string PorExtensoDeReal(this int valor)
        {
            return new Real(valor).ToString();
        }

        public static string PorExtensoDeReal(this long valor)
        {
            return new Real(valor).ToString();
        }

        public static string PorExtensoDeReal(this float valor)
        {
            return new Real(Convert.ToDecimal(valor)).ToString();
        }

        public static string PorExtensoDeReal(this decimal valor)
        {
            return new Real(valor).ToString();
        }
    }
}