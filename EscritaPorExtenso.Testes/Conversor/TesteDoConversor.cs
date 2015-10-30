using System;
using EscritaPorExtenso.Conversor;
using EscritaPorExtenso.Core;
using EscritaPorExtenso.Moeda;
using NUnit.Framework;

namespace EscritaPorExtenso.Testes.Conversor
{
    [TestFixture]
    public class TesteDoConversor
    {
        [Test]
        public void DeveConverterZero()
        {
            var convertido = ConversorDeNumeroParaClasses.Converter(0);
            
            Assert.AreEqual(new PrimeiraClasse(new Unidade(0)), convertido);
        }
        
        [Test]
        public void DeveConverterNumeroUm()
        {
            Assert.AreEqual(new PrimeiraClasse(new Unidade(1)), ConversorDeNumeroParaClasses.Converter(1));
        }

        [Test]
        public void DeveConverterUmaDezena()
        {
            Assert.AreEqual(new PrimeiraClasse(new Dezena(1)), ConversorDeNumeroParaClasses.Converter(10));
        }

        [Test]
        public void DeveConverterUmaDezenaComUnidade()
        {
            var convertido = ConversorDeNumeroParaClasses.Converter(13);
            
            Assert.AreEqual(new PrimeiraClasse(new Dezena(1, new Unidade(3))), convertido);
        }

        [Test]
        public void DeveConverterUmaCentena()
        {
            var convertido = ConversorDeNumeroParaClasses.Converter(200);
            
            Assert.AreEqual(new PrimeiraClasse(new Centena(2)), convertido);
        }

        [Test]
        public void DeveConverterUmaCentenaComDezenaEUnidade()
        {
            var convertido = ConversorDeNumeroParaClasses.Converter(666);

            Assert.AreEqual(new PrimeiraClasse(new Centena(6, new Dezena(6, new Unidade(6)))), convertido);
        }

        [Test]
        public void DeveConverterMilhar()
        {
            var convertido = ConversorDeNumeroParaClasses.Converter(1000);
            
            Assert.AreEqual(new Milhar(new Unidade(1)), convertido);    
        }

        [Test]
        public void DeveConverterMilharComClasseAnterior()
        {
            var convertido = ConversorDeNumeroParaClasses.Converter(1984);

            Assert.AreEqual(new Milhar(new Unidade(1), new PrimeiraClasse(new Centena(9, new Dezena(8, new Unidade(4))))), convertido);
        }

        [Test]
        public void DeveConverterMilharCompletoComPrimeiraClasseCompleta()
        {
            var convertido = ConversorDeNumeroParaClasses.Converter(999999);

            Assert.AreEqual(new Milhar(new Centena(9, new Dezena(9, new Unidade(9))), new PrimeiraClasse(new Centena(9, new Dezena(9, new Unidade(9))))), convertido);
        }

        [Test]
        public void NaoDeveConverterNumeroMaiorQueOSuportado()
        {
            var numeroMaiorQueOMaximo = Convert.ToInt64(new string('9', ConversorDeNumeroParaClasses.NumeroDeClasses * 3 + 1));

            var excecao = Assert.Throws<Exception>(() => ConversorDeNumeroParaClasses.Converter(numeroMaiorQueOMaximo));
            Assert.AreEqual(string.Format("O valor {0} é maior que o suportado pela biblioteca", numeroMaiorQueOMaximo), excecao.Message);
        }

        public void DeveConverterCentenaDeMilhar()
        {
            var convertido = ConversorDeNumeroParaClasses.Converter(100000);

            Assert.AreEqual(new Milhar(new Centena(1)), convertido);
        }

        public void DeveConverterUmMilhao()
        {
            var convertido = ConversorDeNumeroParaClasses.Converter((int) 1e6);

            Assert.AreEqual(new Milhao(new Unidade(1)), convertido);
        }

    }
}