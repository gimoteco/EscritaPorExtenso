using NUnit.Framework;
using System;

namespace EscritaPorExtenso.Testes
{
    [TestFixture]
    public class TesteDeInteiro
    {
        [Test]
        public void DeveEscreverUmNumeroInteiro()
        {
            Assert.AreEqual("dois mil", 2000.PorExtenso());
        }

        [TestCase("cento e oito", 108)]
        [TestCase("mil e oitenta", 1080)]
        [TestCase("dez mil e noventa", 10090)]
        [TestCase("dez mil, cento e noventa e dois", 10192)]
        [TestCase("dez mil e dois", 10002)]
        public void DeveEscreverSemConjuncaoQuandoAlgumAlgarismoForZero(string numeroPorExtensoEsperado, int numero)
        {
            Assert.AreEqual(numeroPorExtensoEsperado, numero.PorExtenso());
        }

        [Test]
        public void DeveEscreverUmNumeroInteiroShort()
        {
            Assert.AreEqual("um", Int16.Parse("1").PorExtenso());
        }

        [Test]
        public void DeveEscreverUmNumeroInteiroLong()
        {
            Assert.AreEqual("dois mil", 2000L.PorExtenso());
        }
    }
}