using EscritorDeNumeroPorExtenso.ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace EscritorDeNumeroPorExtenso.Testes
{
    [TestClass]
    public class TesteDeCentena
    {
        [TestMethod]
        public void DeveGerarUmaCentenaSimples()
        {
            Assert.AreEqual("cem", new Centena(1).ToString());
        }

        [TestMethod]
        public void DeveGerarUmaCentenaComUmaUnidade()
        {
            Assert.AreEqual("cento e um", new Centena(new Unidade(1)).ToString());
        }
    }
}