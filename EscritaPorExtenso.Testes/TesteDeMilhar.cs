using EscritaPorExtenso.Lib;
using NUnit.Framework;

namespace EscritaPorExtenso.Testes
{
    [TestFixture]
    public class TesteDeMilhar
    {
        [Test]
        public void DeveGerarNumeroMil()
        {
            Assert.AreEqual("um mil", new Milhar(new Unidade(1)).ToString());
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

        [Test]
        public void DeveGerarUmMilharComClasseAnteriorCompleta()
        {
            var numero = new Milhar(new Unidade(1), new PrimeiraClasse(new Centena(9, new Dezena(8, new Unidade(4)))));

            var porExtenso = numero.ToString();

            Assert.AreEqual("um mil e novecentos e oitenta e quatro", porExtenso);
        }
    }
}