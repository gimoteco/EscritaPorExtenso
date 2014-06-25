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
            Assert.AreEqual("cento e um", new Centena(1, new Unidade(1)).ToString());
        }

        [TestMethod]
        public void DeveGerarUmaCentenaComDezenaEUmaUnidade()
        {
            Assert.AreEqual("cento e onze", new Centena(1, new Dezena(1, new Unidade(1))).ToString());
        }
        
        [TestMethod]
        public void DeveGerarUmaCentena999()
        {
            Assert.AreEqual("novecentos e noventa e nove", new Centena(9, new Dezena(9, new Unidade(9))).ToString());
        }
    }
}