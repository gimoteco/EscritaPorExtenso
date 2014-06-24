using EscritorDeNumeroPorExtenso.ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace EscritorDeNumeroPorExtenso.Testes
{
    [TestClass]
    public class TesteDeDezena
    {
        [TestMethod]
        public void DeveGerarNumeroDeUmaDezenaSimples()
        {
            Assert.AreEqual("dez", new Dezena(1).Com(new Unidade(0)));
        }

        [TestMethod]
        public void DeveGerarUmaDezenaDaPrimeiraDezena()
        {
            Assert.AreEqual("onze", new Dezena(1).Com(new Unidade(1)));
            Assert.AreEqual("doze", new Dezena(1).Com(new Unidade(2)));
            Assert.AreEqual("dezenove", new Dezena(1).Com(new Unidade(9)));
        }

        [TestMethod]
        public void DeveGerarUmaDezenaQualquer()
        {
            Assert.AreEqual("vinte e um", new Dezena(2).Com(new Unidade(1)));
            Assert.AreEqual("cinquenta e um", new Dezena(5).Com(new Unidade(1)));
        }
    }
}