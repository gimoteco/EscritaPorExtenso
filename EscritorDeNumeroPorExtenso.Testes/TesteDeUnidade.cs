using EscritorDeNumeroPorExtenso.ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace EscritorDeNumeroPorExtenso.Testes
{
    [TestClass]
    public class TesteDeUnidade
    {
        [TestMethod]
        public void DeveGerarNumeroPorExtensoDeUnidade()
        {
            Assert.AreEqual("um", new Unidade(1).ToString());
        }
    }
}
