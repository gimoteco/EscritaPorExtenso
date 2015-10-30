using System;

namespace EscritaPorExtenso.Porcentagem
{
    public static class ExtensoesDePorcentagem
    {
        public static string PorExtensoDePorcentagem(this int valor)
        {
            return valor.PorExtenso() + " por cento";
        }

        public static string PorExtensoDePorcentagem(this long valor)
        {
            return new Porcentagem(valor).ToString();
        }

        public static string PorExtensoDePorcentagem(this double valor)
        {
            return new Porcentagem(Convert.ToDecimal(valor)).ToString();
        }

        public static string PorExtensoDePorcentagem(this decimal valor)
        {
            return new Porcentagem(valor).ToString();
        }
    }
}