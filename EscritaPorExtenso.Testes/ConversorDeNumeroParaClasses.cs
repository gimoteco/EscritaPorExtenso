using System;
using EscritorDeNumeroPorExtenso.ClassLibrary;

namespace EscritorDeNumeroPorExtenso.Testes
{
    public class ConversorDeNumeroParaClasses
    {
        private Type[] _classes;
        private Type[] _ordens;

        public ConversorDeNumeroParaClasses()
        {
            _classes = new[] {typeof(PrimeiraClasse), typeof(Milhar), typeof(Milhao)};
            _ordens = new[] {typeof (Unidade), typeof (Dezena), typeof (Centena)};
        }

        public static IClasse Converter(int numero)
        {
            var textoDoNumero = numero.ToString();
            return new PrimeiraClasse(new Unidade(numero));
        }
    }
}