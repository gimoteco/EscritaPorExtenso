using System;

namespace EscritaPorExtenso.Lib
{
    public static class ExtensoesDeString
    {
        public static int ObterDigitoDoCaracter(this string caracteres, int indiceDoCaracter)
        {
            return Convert.ToInt32(caracteres.Substring(indiceDoCaracter, 1));
        }
    }
    
    public class ConversorDeNumeroParaClasses
    {
        private static IClasse ConstruirClasse<Classe>(params object[] parametros)
        {
            return (IClasse) typeof(Classe).GetConstructors()[0].Invoke(parametros);
        }

        private static IClasse ConverterClasse<Classe>(string digitos)
        {
            
            var primeiroDigito = new Unidade(digitos.ObterDigitoDoCaracter(0));
            if (digitos.Length == 1)
                return  ConstruirClasse<Classe>(primeiroDigito);
            
            var segundoDigito = new Dezena(digitos.ObterDigitoDoCaracter(0), new Unidade(digitos.ObterDigitoDoCaracter(1)));
            if (digitos.Length == 2)
                return ConstruirClasse<Classe>(segundoDigito);
            
            var terceiroDigito = new Centena(digitos.ObterDigitoDoCaracter(0), new Dezena(digitos.ObterDigitoDoCaracter(1), new Unidade(digitos.ObterDigitoDoCaracter(2))));
            return ConstruirClasse<Classe>(terceiroDigito);                
        }

        public static IClasse Converter(int numero)
        {
            var digitos = numero.ToString();
            var primeiraClasse = ConverterClasse<PrimeiraClasse>(digitos.Substring(digitos.Length - digitos.Length, digitos.Length));
            return primeiraClasse;
        }
    }
}