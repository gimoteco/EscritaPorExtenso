using System;
using NUnit.Framework;
using EscritaPorExtenso.Moeda;

namespace EscritaPorExtenso.Testes
{
    [TestFixture]
    public class TesteDePorcentagem
    {
        [Test]
        [TestCase(35, Result="trinta e cinco por cento")]
        [TestCase(1000, Result="mil por cento")]
        [TestCase(1000000, Result="um milhão por cento")]
        public string DeveCalcularPorcentagemSimples(int valor)
        {
            return valor.PorExtensoDePorcentagem();
        }

        [Test, Ignore("TODO")]
        [TestCase(0.3, Result="três décimos por cento")]
        public string DeveEscreverPorExtensoPorcentagemSomenteComDecimos(decimal valor)
        {
            return 1.PorExtensoDePorcentagem();
        }
    }
}

