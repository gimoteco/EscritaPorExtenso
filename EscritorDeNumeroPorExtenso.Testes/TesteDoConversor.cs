using EscritorDeNumeroPorExtenso.ClassLibrary;
using NUnit.Framework;

namespace EscritorDeNumeroPorExtenso.Testes
{
    [TestFixture]
    public class TesteDoConversor
    {
        [Test]
        public void DeveConverterNumeroUm()
        {
            Assert.AreEqual(new PrimeiraClasse(new Unidade(1)), ConversorDeNumeroParaClasses.Converter(1));
        }

        [Test]
        public void DeveConverterNumero9()
        {
            Assert.AreEqual(new PrimeiraClasse(new Unidade(9)), ConversorDeNumeroParaClasses.Converter(9));
        }

        [Test, Ignore("Nao foi implementado")]
        public void DeveConverterUmaDezena()
        {
            Assert.AreEqual(new PrimeiraClasse(new Dezena(1)), ConversorDeNumeroParaClasses.Converter(10));
        }
    }
}