using EscritorDeNumeroPorExtenso.ClassLibrary;
using NUnit.Framework;

namespace EscritorDeNumeroPorExtenso.Testes
{
    [TestFixture]
    public class TesteDeMilhar
    {
        [Test]
        public void DeveGerarNumeroMil()
        {
            Assert.AreEqual("mil", new Milhar(new Unidade(1)).ToString());
        }

        [Test]
        public void DeveGerarNumeroDezMil()
        {
            Assert.AreEqual("dez mil", new Milhar(new Dezena(1)).ToString());
        }

        [Test]
        public void DeveGerarNumeroMilECem()
        {
            Assert.AreEqual("dez mil e cem", new Milhar(new Dezena(1), new PrimeiraClasse(new Centena(1))).ToString());
        }
    }
}