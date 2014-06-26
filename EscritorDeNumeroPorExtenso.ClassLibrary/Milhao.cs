using System;
using System.Linq;

namespace EscritorDeNumeroPorExtenso.ClassLibrary
{
    public class Milhao : IClasse
    {
        private IOrdem Ordem { get; set; }
        private IClasse ClasseAnterior { get; set; }

        public string SulfixoSingular { get { return "milhão"; } }
        public string Sulfixo
        {
            get
            {
                return EhSingular ? SulfixoSingular : SulfixoPlural;
            }
        }

        public bool EhSingular
        {
            get { return Algarismos.Last() == 1 && Algarismos.Length == 1; }
        }

        public string SulfixoPlural { get { return "milhões"; } }

        public int[] Algarismos { get { return Ordem.Algarismos; } }

        public Milhao(IOrdem ordem, IClasse classeAnterior = null)
        {
            Ordem = ordem;
            ClasseAnterior = classeAnterior ?? new Milhar(new Centena(0));
        }

        public override string ToString()
        {
            return Ordem + " " + Sulfixo + 
                (ClasseAnteriorTudoZero ? String.Empty : (" e " + ClasseAnterior));
        }

        private bool ClasseAnteriorTudoZero
        {
            get { return Array.TrueForAll(ClasseAnterior.Algarismos, x => x == 0); }
        }
    }
}