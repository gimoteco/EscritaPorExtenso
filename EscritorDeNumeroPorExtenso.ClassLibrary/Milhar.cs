using System;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.InteropServices;
using System.Security.Cryptography;

namespace EscritorDeNumeroPorExtenso.ClassLibrary
{
    public class Milhar : IClasse
    {
        public IOrdem Ordens { get; set; }
        public IClasse ClasseAnterior { get; set; }
        public string Sulfixo { get { return "mil"; } }

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
                + (TudoZero ? string.Empty : (" e " + classeAnterior));
        }

        private bool EhDoCasoEspecialDoPrimeiroMilhar
        {
            get { return Ordens.Algarismos.First() == 1 && Ordens.Algarismos.Length == 1; }
        }

        private bool TudoZero
        {
            get
            {
                return Array.TrueForAll(ClasseAnterior.Algarismos, x => x == 0);
                //ClasseAnterior.Algarismos.Skip(1).All(x => x == 0);
            }
        }
    }
}