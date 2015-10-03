using System;
using NUnit.Framework;
using EscritaPorExtenso.Lib.Moeda;
using EscritaPorExtenso;

namespace EscritaPorExtenso.Testes
{
    [TestFixture]
    public class TesteDeMoeda
    {
        [Test]
        public void DeveEscreverNumeroSingular()
        {
            Assert.AreEqual("um real", 1.PorExtenso());
        }

        [Test]
        public void DeveEscreverNumeroPlural() 
        {
            Assert.AreEqual("dois reais", 2.PorExtenso());
        }

        [Test]
        public void DeveEscreverNumeroComCentavoSingular()
        {
            Assert.AreEqual("um real e um centavo", 1.01.PorExtenso());
        }

        [Test]
        public void DeveEscreverNumeroComCentavoPlural()
        {
            Assert.AreEqual("duzentos reais e cinquenta centavos", 200.50.PorExtenso());
        }

        [Test]
        public void DeveEscreverNumeroSomenteComCentavos()
        {
            Assert.AreEqual("noventa e nove centavos", 0.99.PorExtenso());
        }

        [Test]
        public void DeveEscreverNumero1000()
        {
            Assert.AreEqual("mil reais", 1000.PorExtenso());
        }

        [Test]
        public void ZeroDeveSerSingular() 
        {
            // + info em http://vestibular.uol.com.br/pegadinhas/ult1796u122.jhtm
            Assert.AreEqual("zero real", 0.PorExtenso());
        }
    }
}

