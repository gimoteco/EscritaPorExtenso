using EscritaPorExtenso.Lib;
using NUnit.Framework;


namespace EscritaPorExtenso.Testes
{
    [TestFixture]
    public class TesteDeCentavos
    {
        [Test]
        public void DeveGerarCinquentaCentesimos()
        {
            Assert.AreEqual("dez centésimos", new Centesimos(new Dezena(1)).ToString());
        }

        [Test]
        public void DeveGerarUmMilhaoECinquentaCentesimos()
        {
            Assert.AreEqual("um milhão e cinquenta centésimos", new Milhao(new Unidade(1), new Centesimos(new Dezena(5))).ToString());
        }

        [Test]
        public void DeveGerarCentesimoNoSingular()
        {
            Assert.AreEqual("um centésimo", new Centesimos(new Unidade(1)).ToString());
        }
    }
}
