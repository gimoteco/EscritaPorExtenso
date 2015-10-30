using System;
using EscritaPorExtenso.Conversor;
using EscritaPorExtenso.Core;

namespace EscritaPorExtenso.Porcentagem
{
    public class Porcentagem
    {
        Classe _parteInteira;
        Classe _parteDecimal;

        public Porcentagem(decimal valor)
        {
            ResolverParteInteira(valor);
            ResolverParteDecimal(valor);
        }

        private void ResolverParteInteira(decimal valor)
        {
            var numeroDaParteInteira = (long)Math.Truncate(valor);

            if (numeroDaParteInteira > 0)
                _parteInteira = ConversorDeNumeroParaClasses.Converter(numeroDaParteInteira);
        }

        private void ResolverParteDecimal(decimal valor)
        {
            var parteDecimal = ((valor - Math.Truncate(valor)) * 100);

            if (parteDecimal - Math.Truncate(parteDecimal) > 0)
                throw new Exception(string.Format("O valor {0} tem mais de duas casas decimais", valor));

            var numeroDaParteDecimal = (long)parteDecimal;

            if (numeroDaParteDecimal <= 0) return;

            numeroDaParteDecimal = ReduzirNumeroDaParteDecimal(numeroDaParteDecimal);
            _parteDecimal = ConversorDeNumeroParaClasses.Converter(numeroDaParteDecimal);
        }

        private static long ReduzirNumeroDaParteDecimal(long numeroDaParteDecimal)
        {
            var ehDivisivelPor10 = numeroDaParteDecimal % 10 == 0;
            return ehDivisivelPor10 ? numeroDaParteDecimal / 10 : numeroDaParteDecimal;
        }

        public override string ToString()
        {
            var temParteInteira = _parteInteira != null;
            var temParteDecimal = _parteDecimal != null;

            var parteInteira = temParteInteira ? _parteInteira.ToString() : "zero";

            if (temParteDecimal)
                return  string.Format("{0} vírgula {1} por cento", parteInteira, _parteDecimal);

            return parteInteira + " por cento";
        }
    }
}