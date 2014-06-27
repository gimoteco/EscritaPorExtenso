using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using EscritorDeNumeroPorExtenso.ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace EscritorDeNumeroPorExtenso.Testes
{
    [TestClass]
    public class TesteDeCentavos
    {
        [TestMethod]
        public void DeveGerarCinquentaCentesimos()
        {
            Assert.AreEqual("dez centésimos", new Centesimos(new Dezena(1)).ToString());
        }

        [TestMethod]
        public void DeveGerarUmMilhaoECinquentaCentesimos()
        {
            Assert.AreEqual("um milhão e cinquenta centésimos", new Milhao(new Unidade(1), new Centesimos(new Dezena(5))).ToString());
        }

        [TestMethod]
        public void DeveGerarCentesimoNoSingular()
        {
            Assert.AreEqual("um centésimo", new Centesimos(new Unidade(1)).ToString());
        }
    }
}
