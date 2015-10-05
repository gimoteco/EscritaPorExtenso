using System;
using EscritaPorExtenso.Conversor;
using EscritaPorExtenso.Core;

namespace EscritaPorExtenso.Moeda
{
    internal class Real
    {
        IClasse _parteInteira;
        IClasse _parteDecimal;
        private string _pluralidadeInteira;
        private string _pluralidadeDecimal;

        public Real(decimal valor)
        {
            var numeroDaParteInteira = (long)Math.Truncate(valor);

            ValidarMaximoPermitido(valor, numeroDaParteInteira);

            if (numeroDaParteInteira > 0)
            {
                _parteInteira = ConversorDeNumeroParaClasses.Converter(numeroDaParteInteira);
                _pluralidadeInteira = ObterPluralidadeDaParteInteira(numeroDaParteInteira);
            }

            var parteDecimal = ((valor - Math.Truncate(valor))*100);

            if (parteDecimal - Math.Truncate(parteDecimal) > 0)
                throw new Exception(string.Format("O valor {0} tem mais de duas casas decimais", valor));

            var numeroDaParteDecimal = (long) parteDecimal;

            if (numeroDaParteDecimal > 0)
            {
                _parteDecimal = ConversorDeNumeroParaClasses.Converter(numeroDaParteDecimal);
                _pluralidadeDecimal = ObterPluralidadeDaParteDecimal(numeroDaParteDecimal);
            }
        }

        private static void ValidarMaximoPermitido(decimal valor, long numeroDaParteInteira)
        {
            var maximoPermitido = ConversorDeNumeroParaClasses.NumeroDeClasses*3;

            if (numeroDaParteInteira.ToString().Length > maximoPermitido)
                throw new Exception(string.Format("O valor {0} é maior que o suportado pela biblioteca", valor));
        }

        private static string ObterPluralidadeDaParteInteira(long parteInteira)
        {
            return parteInteira > 1 ? "reais" : "real";
        }

        private static string ObterPluralidadeDaParteDecimal(long numeroDaParteDecimal)
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

            if (_parteInteira != null)
                return parteInteira;

            return "zero real";
        }
    }
}