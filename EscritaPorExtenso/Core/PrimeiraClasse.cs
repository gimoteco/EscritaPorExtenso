namespace EscritaPorExtenso.Core
{
    internal class PrimeiraClasse : Classe
    {
        internal override string Sufixo { get { return string.Empty; }}

        public PrimeiraClasse(IOrdem ordem, Classe classeAnterior = null)
        {
            Ordem = ordem;
        }

        public override string ToString()
        {
            return Ordem.ToString();
        }
    }
}