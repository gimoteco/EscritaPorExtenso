using System;
using NUnit.Framework;
using EscritaPorExtenso.Lib.Moeda;

namespace EscritaPorExtenso.Testes
{
    [TestFixture]
    public class TesteDeMoeda
    {
        [Test]
        public void DeveEscreverNumeroSingular()
        {
            Assert.AreEqual("um real", new Real(1).ToString());
        }

        [Test]
        public void DeveEscreverNumeroPlural() 
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

        [Test]
        public void DeveEscreverNumeroSomenteComCentavos()
        {
            Assert.AreEqual("noventa e nove centavos", new Real(0.99).ToString());
        }

        [Test]
        public void DeveEscreverNumero1000()
        {
            Assert.AreEqual("mil reais", new Real(1000).ToString());
        }

        [Test]
        public void ZeroDeveSerSingular() 
        {
            // + info em http://vestibular.uol.com.br/pegadinhas/ult1796u122.jhtm
            Assert.AreEqual("zero real", new Real(0).ToString());
        }
    }
}

