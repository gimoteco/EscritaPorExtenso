using System;
using NUnit.Framework;
using EscritaPorExtenso.Core;

namespace EscritaPorExtenso.Testes
{
    [TestFixture]
    public class TesteDePrimeiraClasse
    {
        [Test]
        public void PrimeiraClasseNaoTemSufixo()
        {
            Assert.IsEmpty(new PrimeiraClasse(new Unidade(1)).Sufixo);
        }
    }
}

