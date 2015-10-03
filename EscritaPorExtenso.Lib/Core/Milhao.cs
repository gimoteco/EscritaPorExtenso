using System;
using System.Linq;

namespace EscritaPorExtenso.Lib
{
    public class Milhao : IClasse
    {
        private IOrdem Ordem { get; set; }
        private IClasse ClasseAnterior { get; set; }
        public string Sufixo { get { return EhSingular ? "milhão" : "milhões"; } }
        private bool EhSingular { get { return Algarismos.Last() == 1 && Algarismos.Length == 1; } }
        public int[] Algarismos { get { return Ordem.Algarismos; } }

        public Milhao(IOrdem ordem, IClasse classeAnterior = null)
        {
            Ordem = ordem;
            ClasseAnterior = classeAnterior ?? new Milhar(new Centena(0));
        }

        public override string ToString()
        {
            return Ordem + " " + Sufixo +
                (ClasseAnteriorTudoZero ? String.Empty : (" e " + ClasseAnterior));
        }

        private bool ClasseAnteriorTudoZero
        {
            get { return Array.TrueForAll(ClasseAnterior.Algarismos, algarismo => algarismo == 0); }
        }
    }
}