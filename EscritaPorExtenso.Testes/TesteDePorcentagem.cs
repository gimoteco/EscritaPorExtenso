using System;
using EscritaPorExtenso.Conversor;
using EscritaPorExtenso.Porcentagem;
using NUnit.Framework;

namespace EscritaPorExtenso.Testes
{
    [TestFixture]
    public class TesteDePorcentagem
    {
        /*
         * http://www.migalhas.com.br/Gramatigalhas/10,MI24539,91041-Como+se+le+8347
         */

        [Test]
        [TestCase(35, Result="trinta e cinco por cento")]
        [TestCase(1000, Result="mil por cento")]
        [TestCase(1000000, Result="um milhão por cento")]
        public string DeveCalcularPorcentagemSimples(int valor)
        {
            return valor.PorExtensoDePorcentagem();
        }

        [Test]
        [TestCase(35, Result = "trinta e cinco por cento")]
        [TestCase(1000, Result = "mil por cento")]
        [TestCase(1000000, Result = "um milhão por cento")]
        public string DeveCalcularPorcentagemSimplesParaLong(long valor)
        {
            return valor.PorExtensoDePorcentagem();
        }
       
        [Test]
        [TestCase(83.47, Result= "oitenta e três vírgula quarenta e sete por cento")]
        [TestCase(0.3, Result= "zero vírgula três por cento")]
        [TestCase(78, Result= "setenta e oito por cento")]
        public string DeveEscreverPorExtensoPorcentagemParaDecimal(decimal valor)
        {
            return valor.PorExtensoDePorcentagem();
        }

        [Test]
        [TestCase(125.89, Result = "cento e vinte e cinco vírgula oitenta e nove por cento")]
        [TestCase(0.9, Result = "zero vírgula nove por cento")]
        [TestCase(356, Result = "trezentos e cinquenta e seis por cento")]
        public string DeveEscreverPorExtensoPorcentagemParaDouble(double valor)
        {
            return valor.PorExtensoDePorcentagem();
        }

        [Test]
        public void NaoDeveConverterNumeroMaiorQueOSuportado()
        {
            var numeroMaiorQueOMaximo = Convert.ToInt64(new string('9', ConversorDeNumeroParaClasses.NumeroDeClasses * 3 + 1));

            var excecao = Assert.Throws<Exception>(() => numeroMaiorQueOMaximo.PorExtensoDePorcentagem());
            Assert.AreEqual(string.Format("O valor {0} é maior que o suportado pela biblioteca", numeroMaiorQueOMaximo), excecao.Message);
        }

        [Test]
        public void NaoDeveConverterNumeroComMaisDeDuasCasasDecimais()
        {
            var valor = 0.999;

            var excecao = Assert.Throws<Exception>(() => valor.PorExtensoDePorcentagem());

            Assert.AreEqual(string.Format("O valor {0} tem mais de duas casas decimais", valor), excecao.Message);
        }
    }
}

