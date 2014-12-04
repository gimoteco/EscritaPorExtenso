using EscritorDeNumeroPorExtenso.ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace EscritorDeNumeroPorExtenso.Testes
{
    [TestClass]
    public class TesteDoConversor
    {
        [TestMethod]
        public void DeveConverterNumeroUm()
        {
            Assert.AreEqual(new PrimeiraClasse(new Unidade(1)), ConversorDeNumeroParaClasses.Converter(1));
        }

        [TestMethod]
        public void DeveConverterNumero9()
        {
            Assert.AreEqual(new PrimeiraClasse(new Unidade(9)), ConversorDeNumeroParaClasses.Converter(9));
        }

        [TestMethod]
        public void DeveConverterUmaDezena()
        {
            Assert.AreEqual(new PrimeiraClasse(new Dezena(1)), ConversorDeNumeroParaClasses.Converter(10));
        }
    }
}