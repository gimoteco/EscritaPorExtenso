using System;
using System.Linq;

namespace EscritorDeNumeroPorExtenso.ClassLibrary
{
    public class Milhar : IClasse
    {
        private IOrdem Ordens { get; set; }
        public IClasse ClasseAnterior { get; set; }
        public string Sulfixo { get { return "mil"; } }
        public string SulfixoPlural { get { return Sulfixo; } }

        public int[] Algarismos
        {
            get { return Ordens.Algarismos.Concat(ClasseAnterior.Algarismos).ToArray(); }
        }

        public Milhar(IOrdem ordem, IClasse classeAnterior = null)
        {
            Ordens = ordem;
            ClasseAnterior = classeAnterior ?? new PrimeiraClasse(new Centena(0));
        }

        public override string ToString()
        {
            return EhDoCasoEspecialDoPrimeiroMilhar ? Sulfixo : LigaClasses(Ordens + " " + Sulfixo, ClasseAnterior);
        }

        private string LigaClasses(string ordem, IClasse classeAnterior)
        {
            return (EhDoCasoEspecialDoPrimeiroMilhar ? (ordem + " " + classeAnterior) : ordem)
                + (ClasseAnteriorTudoZero ? string.Empty : (" e " + classeAnterior));
        }

        private bool EhDoCasoEspecialDoPrimeiroMilhar
        {
            get { return Ordens.Algarismos.First() == 1 && Ordens.Algarismos.Length == 1; }
        }

        private bool ClasseAnteriorTudoZero
        {
            get
            {
                return Array.TrueForAll(ClasseAnterior.Algarismos, x => x == 0);
            }
        }
    }
}