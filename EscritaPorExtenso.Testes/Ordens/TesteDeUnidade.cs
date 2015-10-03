using EscritaPorExtenso.Lib;
using NUnit.Framework;

namespace EscritaPorExtenso.Testes
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
