using System;

namespace EscritaPorExtenso.Lib.Moeda
{
    public class Real
    {
        IClasse _parteInteira;
        IClasse _parteDecimal;
        private string _pluralidadeInteira;
        private string _pluralidadeDecimal;

        public Real(double valor)
        {
            var numeroDaParteInteira = (int)Math.Truncate(valor);

            if (numeroDaParteInteira > 0)
            {
                _parteInteira = ConversorDeNumeroParaClasses.Converter(numeroDaParteInteira);
                _pluralidadeInteira = ObterPluralidadeDaParteInteira(numeroDaParteInteira);
            }

            var numeroDaParteDecimal = (int) ((valor - Math.Truncate(valor)) * 100);

            if (numeroDaParteDecimal > 0)
            {
                _parteDecimal = ConversorDeNumeroParaClasses.Converter(numeroDaParteDecimal);
                _pluralidadeDecimal = ObterPluralidadeDaParteDecimal(numeroDaParteDecimal);
            }
        }

        private static string ObterPluralidadeDaParteInteira(int parteInteira)
        {
            return parteInteira > 1 ? "reais" : "real";
        }

        private static string ObterPluralidadeDaParteDecimal(int numeroDaParteDecimal)
        {
            return numeroDaParteDecimal > 1 ? "centavos" : "centavo";
        }

        public override string ToString()
        {
            string parteInteira = string.Format("{0} {1}", _parteInteira, _pluralidadeInteira);
            string parteDecimal = string.Format("{0} {1}", _parteDecimal, _pluralidadeDecimal);

            if (_parteDecimal != null && _parteInteira != null)
                return string.Format("{0} e {1}", parteInteira, parteDecimal);

            if (_parteDecimal != null)
                return parteDecimal;
            
            return parteInteira;
        }
    }
}