namespace EscritorDeNumeroPorExtenso.ClassLibrary
{
    public interface IClasse
    {
        string Sulfixo { get; }
        string SulfixoPlural { get; }

        int[] Algarismos { get; }
    }
}