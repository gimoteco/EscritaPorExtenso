using System;
using EscritaPorExtenso.Conversor;
using EscritaPorExtenso.Moeda;
using NUnit.Framework;

namespace EscritaPorExtenso.Testes
{
    [TestFixture]
    public class TesteDeMoeda
    {
        [Test]
        public void DeveEscreverNumeroSingular()
        {
            Assert.AreEqual("um real", 1.PorExtensoDeReal());
        }

        [Test]
        public void DeveEscreverNumeroPlural() 
        {
            Assert.AreEqual("dois reais", 2.PorExtensoDeReal());
        }

        [Test]
        public void DeveEscreverNumeroComCentavoSingular()
        {
            Assert.AreEqual("um real e um centavo", 1.01.PorExtensoDeReal());
        }

        [Test]
        public void DeveEscreverNumeroComCentavoPlural()
        {
            Assert.AreEqual("duzentos reais e cinquenta centavos", 200.50.PorExtensoDeReal());
        }

        [Test]
        public void DeveEscreverNumeroSomenteComCentavos()
        {
            Assert.AreEqual("noventa e nove centavos", 0.99.PorExtensoDeReal());
        }

        [Test]
        public void DeveEscreverNumeroSomenteComCentavosDecimal()
        {
            Assert.AreEqual("noventa e nove centavos", 0.99m.PorExtensoDeReal());
        }

        [Test]
        public void DeveEscreverNumeroSomenteComCentavosFloat()
        {
            Assert.AreEqual("noventa e nove centavos", 0.99f.PorExtensoDeReal());
        }

        [Test]
        public void DeveEscreverNumeroSomenteComCentavosInt()
        {
            Assert.AreEqual("nove reais", 9.PorExtensoDeReal());
        }

        [Test]
        public void DeveEscreverNumeroSomenteComCentavosLong()
        {
            Assert.AreEqual("um real", 1L.PorExtensoDeReal());
        }

        [Test]
        public void DeveEscreverNumero1000()
        {
            Assert.AreEqual("mil reais", 1000.PorExtensoDeReal());
        }

        [Test]
        public void ZeroDeveSerSingular() 
        {
            // + info em http://vestibular.uol.com.br/pegadinhas/ult1796u122.jhtm
            Assert.AreEqual("zero real", 0.PorExtensoDeReal());
        }

        [Test]
        public void NaoDeveConverterNumeroMaiorQueOSuportado()
        {
            var numeroMaiorQueOMaximo = Convert.ToInt64(new string('9', ConversorDeNumeroParaClasses.NumeroDeClasses  * 3 + 1));

            var excecao = Assert.Throws<Exception>(() => numeroMaiorQueOMaximo.PorExtensoDeReal());
            Assert.AreEqual(string.Format("O valor {0} é maior que o suportado pela biblioteca", numeroMaiorQueOMaximo), excecao.Message);
        }

        [Test]
        public void NaoDeveConverterNumeroComMaisDeDuasCasasDecimais()
        {
            var valor = 0.999;

            var excecao = Assert.Throws<Exception>(() => valor.PorExtensoDeReal());

            Assert.AreEqual(string.Format("O valor {0} tem mais de duas casas decimais", valor), excecao.Message);
        }
    }
}

