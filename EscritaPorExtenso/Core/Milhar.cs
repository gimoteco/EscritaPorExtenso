using System;
using System.Linq;

namespace EscritaPorExtenso.Core
{
    internal class Milhar : IClasse
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
            var ehDaPrimeiraUnidade = Ordens.GetType() == typeof (Unidade) && Ordens.Algarismos.First() == 1;

            if (ehDaPrimeiraUnidade)
                return LigaClasses(Sufixo , ClasseAnterior);

            return LigaClasses(Ordens + " " + Sufixo, ClasseAnterior);
        }

        private string LigaClasses(string ordem, IClasse classeAnterior)
        {
            var numeroDaClasseAnterior = Convert.ToInt64(string.Join(string.Empty, classeAnterior.Algarismos.Select(algarismo => algarismo.ToString())));

            var ehExcecao = numeroDaClasseAnterior % 10 == 0 || numeroDaClasseAnterior < 100;
            var conjuncao = ehExcecao ? " e " : ", ";
            return ordem + (EhClasseAnteriorTudoZero ? string.Empty : (conjuncao + classeAnterior));
        }

        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
            {
                return false;
            }

            return ToString() == obj.ToString();
        }

        public override int GetHashCode()
        {
            return ToString().GetHashCode();
        }

        private bool EhDoCasoEspecialDoPrimeiroMilhar
        {
            get { return Ordens.Algarismos.First() == 1 && Ordens.Algarismos.Length == 1 && EhClasseAnteriorTudoZero; }
        }

        private bool EhClasseAnteriorTudoZero { get { return Array.TrueForAll(ClasseAnterior.Algarismos, algarismo => algarismo == 0); } }
    }
}