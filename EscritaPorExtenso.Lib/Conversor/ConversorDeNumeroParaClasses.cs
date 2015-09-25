using System;

namespace EscritaPorExtenso.Lib
{
    public class ConversorDeNumeroParaClasses
    {
//        private Type[] _classes;
//        private Type[] _ordens;
//
//        public ConversorDeNumeroParaClasses()
//        {
//            _classes = new[] {typeof(PrimeiraClasse), typeof(Milhar), typeof(Milhao)};
//            _ordens = new[] {typeof (Unidade), typeof (Dezena), typeof (Centena)};
//        }

        public static IClasse Converter(int numero)
        {
            var textoDoNumero = numero.ToString();

            if (textoDoNumero.Length == 2)
            {
                var primeiroDigito = Convert.ToInt32(textoDoNumero.Substring(0, 1));
                var segundoDigito = Convert.ToInt32(textoDoNumero.Substring(1, 1));
                  
                return new PrimeiraClasse(new Dezena(primeiroDigito, new Unidade(segundoDigito)));    
            }
            else if (textoDoNumero.Length == 3)
            {
                var primeiroDigito = Convert.ToInt32(textoDoNumero.Substring(0, 1));
                var segundoDigito = Convert.ToInt32(textoDoNumero.Substring(1, 1));
                var terceiroDigito = Convert.ToInt32(textoDoNumero.Substring(2, 1));

                return new PrimeiraClasse(new Centena(primeiroDigito, new Dezena(segundoDigito, new Unidade(terceiroDigito))));    
            }


            return new PrimeiraClasse(new Unidade(Convert.ToInt32(textoDoNumero)));
        }
    }
}