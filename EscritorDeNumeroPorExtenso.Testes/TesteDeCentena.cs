using EscritorDeNumeroPorExtenso.ClassLibrary;
using NUnit.Framework;

namespace EscritorDeNumeroPorExtenso.Testes
{
    [TestFixture]
    public class TesteDeCentena
    {
        [Test]
        public void DeveGerarUmaCentenaSimples()
        {
            Assert.AreEqual("cem", new Centena(1).ToString());
        }

        [Test]
        public void DeveGerarUmaCentenaComUmaUnidade()
        {
            Assert.AreEqual("cento e um", new Centena(1, new Unidade(1)).ToString());
        }

        [Test]
        public void DeveGerarUmaCentenaComDezenaEUmaUnidade()
        {
            Assert.AreEqual("cento e onze", new Centena(1, new Dezena(1, new Unidade(1))).ToString());
        }

        [Test]
        public void DeveGerarUmaCentena999()
        {
            Assert.AreEqual("novecentos e noventa e nove", new Centena(9, new Dezena(9, new Unidade(9))).ToString());
        }
    }
}