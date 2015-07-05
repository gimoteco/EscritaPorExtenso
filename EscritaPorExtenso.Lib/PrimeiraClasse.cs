using System;

namespace EscritorDeNumeroPorExtenso.ClassLibrary
{
    public class PrimeiraClasse : IClasse
    {
        private IOrdem Ordem { get; set; }
        public string Sufixo { get; private set; }
        public string SulfixoPlural { get; private set; }

        public int[] Algarismos
        {
            get { return Ordem.Algarismos; }
        }

        public PrimeiraClasse(IOrdem ordem)
        {
            Ordem = ordem;
        }

        public override string ToString()
        {
            return Ordem.ToString();
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
    }
}