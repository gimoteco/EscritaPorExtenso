using System;
using System.Linq;

namespace EscritaPorExtenso.Lib
{
    public class Milhar : IClasse
    {
        private IOrdem Ordens { get; set; }
        private IClasse ClasseAnterior { get; set; }
        public string Sufixo { get { return "mil"; } }
        public int[] Algarismos { get { return Ordens.Algarismos.Concat(ClasseAnterior.Algarismos).ToArray(); } }

        public Milhar(IOrdem ordem, IClasse classeAnterior = null)
        {
            Ordens = ordem;
            ClasseAnterior = classeAnterior ?? new PrimeiraClasse(new Centena(0));
        }

        public override string ToString()
        {
            return EhDoCasoEspecialDoPrimeiroMilhar ? Sufixo : LigaClasses(Ordens + " " + Sufixo, ClasseAnterior);
        }

        private string LigaClasses(string ordem, IClasse classeAnterior)
        {
            return (EhDoCasoEspecialDoPrimeiroMilhar ? (ordem + " " + classeAnterior) : ordem)
                + (EhClasseAnteriorTudoZero ? string.Empty : (" e " + classeAnterior));
        }

        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
            {
                return false;
            }

            return ToString() == obj.ToString();
        }

        private bool EhDoCasoEspecialDoPrimeiroMilhar
        {
            get { return Ordens.Algarismos.First() == 1 && Ordens.Algarismos.Length == 1 && EhClasseAnteriorTudoZero; }
        }

        private bool EhClasseAnteriorTudoZero { get { return Array.TrueForAll(ClasseAnterior.Algarismos, algarismo => algarismo == 0); } }
    }
}