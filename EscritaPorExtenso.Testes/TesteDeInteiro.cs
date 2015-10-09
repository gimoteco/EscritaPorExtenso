using NUnit.Framework;

namespace EscritaPorExtenso.Testes
{
    [TestFixture]
    public class TesteDeInteiro
    {
        [Test]
        public void DeveEscreverUmNumeroInteiro()
        {
            Assert.AreEqual("dois mil", 2000.PorExtenso());
        }
    }
}