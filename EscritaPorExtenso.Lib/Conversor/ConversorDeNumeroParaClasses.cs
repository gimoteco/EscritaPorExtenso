using System;
using System.Linq;
using EscritaPorExtenso.Lib.Helpers;

namespace EscritaPorExtenso.Lib
{
    public class ConversorDeNumeroParaClasses
    {
        public static int NumeroDeClasses { get { return _classes.Length; } }
        private static readonly Type[] _ordens = { typeof(Unidade), typeof(Dezena), typeof(Centena) };
        private static readonly Type[] _classes = { typeof(PrimeiraClasse), typeof(Milhar), typeof(Milhao) };

        public static IClasse Converter(int numero)
        {
            var digitos = InverterNumero(numero);
            var numeroDeClasses = ObterNumeroDeClasses(digitos);
            var classes = ConstruirClasses(digitos, numeroDeClasses);

            return classes;
        }

        private static IClasse ConstruirClasses(string digitos, int numeroDeClasses)
        {
            IClasse classeAtual = null;

            for (var indiceDaClasse = 0; indiceDaClasse < numeroDeClasses; indiceDaClasse++)
            {
                var tipoClasseAtual = _classes[indiceDaClasse];
                var ordens = ConstruirOrdens(digitos, indiceDaClasse);
                classeAtual = tipoClasseAtual.Construir<IClasse>(ordens, classeAtual);
            }
            return classeAtual;
        }

        private static IOrdem ConstruirOrdens(string digitos, int indiceDaClasse)
        {
            IOrdem ordemAtual = null;
            for (var indiceDaOrdem = 0; indiceDaOrdem < ObterNumeroDeOrdens(digitos, indiceDaClasse); indiceDaOrdem++)
            {
                var tipoOrdemAtual = _ordens[indiceDaOrdem];
                var digitoParaEncapsular = digitos.ObterDigitoPorOrdemEClasse(indiceDaClasse, indiceDaOrdem);
                ordemAtual = tipoOrdemAtual.Construir<IOrdem>(digitoParaEncapsular, ordemAtual);
            }
            return ordemAtual;
        }

        private static int ObterNumeroDeOrdens(string digitos, int indiceDaClasse)
        {
            return Math.Min(3, digitos.Length - indiceDaClasse * NumeroDeClasses);
        }

        private static int ObterNumeroDeClasses(string digitos)
        {
            return (int)Math.Ceiling((decimal) digitos.Length / NumeroDeClasses);
        }

        private static string InverterNumero(int numero)
        {
            return new string(numero.ToString().Reverse().ToArray());
        }
    }
}