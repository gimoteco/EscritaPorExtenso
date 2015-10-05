using EscritaPorExtenso.Core;
using NUnit.Framework;

namespace EscritaPorExtenso.Testes.Classes
{
    [TestFixture]
    public class TesteDeMilhao
    {
        [Test]
        public void DeveGerarNumeroUmMilhao()
        {
            Assert.AreEqual("um milhão", new Milhao(new Unidade(1)).ToString());
        }

        [Test]
        public void DeveGerarNumeroDezMilhoes()
        {
            Assert.AreEqual("dez milhões", new Milhao(new Dezena(1)).ToString());
        }

        [Test]
        public void DeveGerarNumeroUmMilhaoECemMil()
        {
            Assert.AreEqual("um milhão e cem mil", new Milhao(new Unidade(1), new Milhar(new Centena(1))).ToString());
        }

        [Test]
        public void DeveGerarNumeroUmMilhaoECemMilEUm()
        {
            Assert.AreEqual("um milhão e cem mil e um", new Milhao(new Unidade(1), new Milhar(new Centena(1), new PrimeiraClasse(new Unidade(1)))).ToString());
        }

        [Test]
        public void DeveGerarNumero1111e3()
        {
            Assert.AreEqual("um milhão e cento e onze mil", new Milhao(new Unidade(1), new Milhar(new Centena(1, new Dezena(1, new Unidade(1))))).ToString());
        }
    }
}