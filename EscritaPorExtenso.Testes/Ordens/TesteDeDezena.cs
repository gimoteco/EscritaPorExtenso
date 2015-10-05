using EscritaPorExtenso.Core;
using NUnit.Framework;

namespace EscritaPorExtenso.Testes.Ordens
{
    [TestFixture]
    public class TesteDeDezena
    {
        [Test]
        public void DeveGerarNumeroDeUmaDezenaSimples()
        {
            Assert.AreEqual("dez", new Dezena(1).ToString());
        }

        [Test]
        public void DeveGerarUmaDezenaDaPrimeiraDezena()
        {
            Assert.AreEqual("onze", new Dezena(1, new Unidade(1)).ToString());
            Assert.AreEqual("doze", new Dezena(1, new Unidade(2)).ToString());
            Assert.AreEqual("dezenove", new Dezena(1, new Unidade(9)).ToString());
        }

        [Test]
        public void DeveGerarUmaDezenaQualquer()
        {
            Assert.AreEqual("vinte e um", new Dezena(2, new Unidade(1)).ToString());
            Assert.AreEqual("cinquenta e um", new Dezena(5, new Unidade(1)).ToString());
        }
    }
}