using EscritaPorExtenso.Core;
using NUnit.Framework;

namespace EscritaPorExtenso.Testes.Classes
{
    [TestFixture]
    public class TesteDeMilhao
    {
        [Test]
        [TestCase("um milhão", 1)]
        [TestCase("cinco milhões", 5)]
        [TestCase("nove milhões", 9)]
        public void DeveEscreverPorExtensoUnidadeDeMilhao(string numeroPorExtenso, int unidade)
        {
            Assert.AreEqual(numeroPorExtenso, new Milhao(new Unidade(unidade)).ToString());
        }

        [Test]
        public void ObjetosDiferentesDevemSerDiferentes()
        {
            Assert.IsFalse(new Milhao(new Unidade(1)).Equals(1));
        }

        [Test]
        public void HashcodeDaClasseDeveSerONumeroPorExtenso()
        {
            var umMilhao = new Milhao(new Unidade(1));

            Assert.AreEqual(umMilhao.GetHashCode(), umMilhao.ToString().GetHashCode());
        }

        // TODO: Remover anotação test
        [Test]
        [TestCase("dez milhões", 1)]
        [TestCase("vinte milhões", 2)]
        [TestCase("noventa milhões", 9)]
        public void DeveEscreverPorExtensoDezenaDeMilhao(string numeroPorExtenso, int dezena)
        {
            Assert.AreEqual(numeroPorExtenso, new Milhao(new Dezena(dezena)).ToString());
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
            Assert.AreEqual("um milhão, cento e onze mil", new Milhao(new Unidade(1), new Milhar(new Centena(1, new Dezena(1, new Unidade(1))))).ToString());
        }
    }
}