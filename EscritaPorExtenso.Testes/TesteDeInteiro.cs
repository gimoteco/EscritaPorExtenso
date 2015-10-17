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