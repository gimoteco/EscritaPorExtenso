using System.Linq;

namespace EscritaPorExtenso.Lib
{
    public class Centesimos : IClasse
    {
        private IOrdem Ordem { get; set; }

        private bool EhSingular
        {
            get { return Algarismos.Last() == 1 && Algarismos.Length == 1; }
        }

        public string Sufixo
        {
            get { return EhSingular ? "centésimo" : "centésimos"; }
        }

        public int[] Algarismos { get { return Ordem.Algarismos; } }

        public Centesimos(IOrdem ordem)
        {
            Ordem = ordem;
        }

        public override string ToString()
        {
            return Ordem + " " + Sufixo;
        }
    }
}