using System;

namespace EscritaPorExtenso.Lib.Helpers
{
    public static class ExtensoesDeString
    {
        public static int ObterDigitoPorOrdemEClasse(this string caracteres, int indiceDaClasse, int indiceDaOrdem)
        {
            return Convert.ToInt32(caracteres.Substring(indiceDaClasse * ConversorDeNumeroParaClasses.NumeroDeClasses + indiceDaOrdem, 1));
        }
    }
}