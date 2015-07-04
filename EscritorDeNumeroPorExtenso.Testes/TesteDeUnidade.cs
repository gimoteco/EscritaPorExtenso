using EscritorDeNumeroPorExtenso.ClassLibrary;
using NUnit.Framework;

namespace EscritorDeNumeroPorExtenso.Testes
{
    [TestFixture]
    public class TesteDeUnidade
    {
        [Test]
        public void DeveGerarNumeroPorExtensoDeUnidade()
        {
            Assert.AreEqual("um", new Unidade(1).ToString());
        }
    }
}
