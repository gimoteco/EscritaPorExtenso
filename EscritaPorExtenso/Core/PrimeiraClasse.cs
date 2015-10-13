namespace EscritaPorExtenso.Core
{
    internal class PrimeiraClasse : Classe
    {
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