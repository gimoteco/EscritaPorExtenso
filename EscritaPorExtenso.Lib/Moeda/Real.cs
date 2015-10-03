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
            _parteInteira = ConversorDeNumeroParaClasses.Converter(numeroDaParteInteira);
            _pluralidadeInteira = ObterPluralidadeDaParteInteira(numeroDaParteInteira);
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
            var parteInteira = string.Format("{0} {1}", _parteInteira, _pluralidadeInteira);

            if (_parteDecimal == null)
                return parteInteira;
            
            return string.Format("{0} e {1} {2}", parteInteira, _parteDecimal, _pluralidadeDecimal);
        }
    }
}