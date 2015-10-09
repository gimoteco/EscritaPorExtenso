using EscritaPorExtenso.Conversor;

namespace EscritaPorExtenso
{
    public static class ExtensoesDeNumerosInteiros
    {
        public static string PorExtenso(this int valor)
        {
            return ConversorDeNumeroParaClasses.Converter(valor).ToString();
        }

        public static string PorExtenso(this short valor)
        {
            return ConversorDeNumeroParaClasses.Converter(valor).ToString();
        }

        public static string PorExtenso(this long valor)
        {
            return ConversorDeNumeroParaClasses.Converter(valor).ToString();
        }
    }
}