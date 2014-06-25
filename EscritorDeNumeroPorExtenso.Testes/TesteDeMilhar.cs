using EscritorDeNumeroPorExtenso.ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace EscritorDeNumeroPorExtenso.Testes
{
    [TestClass]
    public class TesteDeMilhar
    {
        [TestMethod]
        public void DeveGerarNumeroMil()
        {
            Assert.AreEqual("mil", new Milhar(new Unidade(1)).ToString());
        }
        
        [TestMethod]
        public void DeveGerarNumeroDezMil()
        {
            Assert.AreEqual("dez mil", new Milhar(new Dezena(1)).ToString());
        }

        [TestMethod]
        public void DeveGerarNumeroMilECem()
        {
            Assert.AreEqual("dez mil e cem", new Milhar(new Dezena(1), new PrimeiraClasse(new Centena(1))).ToString());
        }
    }
}