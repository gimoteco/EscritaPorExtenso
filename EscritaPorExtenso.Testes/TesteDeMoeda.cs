using System;
using NUnit.Framework;
using EscritaPorExtenso.Lib.Moeda;

namespace EscritaPorExtenso.Testes
{
    [TestFixture]
    public class TesteDeMoeda
    {
        [Test]
        public void DeveEscreverPorExtensoNumeroSingular()
        {
            Assert.AreEqual("um real", new Real(1).ToString());
        }

        [Test]
        public void DeveEscreverPorExtensoNumeroPlural() 
        {
            Assert.AreEqual("dois reais", new Real(2).ToString());
        }

        [Test]
        public void DeveEscreverNumeroComCentavoSingular()
        {
            Assert.AreEqual("um real e um centavo", new Real(1.01).ToString());
        }

        [Test]
        public void DeveEscreverNumeroComCentavoPlural()
        {
            Assert.AreEqual("duzentos reais e cinquenta centavos", new Real(200.50).ToString());
        }
    }
}

