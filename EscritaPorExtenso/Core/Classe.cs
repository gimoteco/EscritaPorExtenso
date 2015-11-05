using System;
using System.Linq;

namespace EscritaPorExtenso.Core
{
    internal abstract class Classe
    {
        abstract internal string Sufixo { get; }
        virtual protected Classe ClasseAnterior { get; set; }
        protected Ordem Ordem { get; set; }
        internal int[] Algarismos { get { return Ordem.Algarismos; } }

        protected bool EhSingular { get { return Algarismos.Last() == 1 && Algarismos.Length == 1; } }

        protected static long ConverterParaNumero(Classe classeAnterior)
        {
            var numeroDaClasseAnterior = Convert.ToInt64(string.Join(string.Empty, classeAnterior.Algarismos.Take(3).Select(algarismo => algarismo.ToString())));
            return numeroDaClasseAnterior;
        }

        protected static string ObterConjuncao(Classe classeAnterior)
        {
            var numeroDaClasseAnterior = ConverterParaNumero(classeAnterior);
            var ehExcecao = numeroDaClasseAnterior % 10 == 0 || numeroDaClasseAnterior < 100;
            return ehExcecao ? " e " : ", ";
        }

        protected bool EhClasseAnteriorTudoZero { get { return Array.TrueForAll(ClasseAnterior.Algarismos, algarismo => algarismo == 0); } }

        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
            {
                return false;
            }

            return ToString() == obj.ToString();
        }

        protected string LigaClasses(string ordem, Classe classeAnterior)
        {
            var conjuncao = ObterConjuncao(classeAnterior);
            var deveColocarConjuncao = classeAnterior.Algarismos.Take(1).First() != 0;
            var classeAnteriorPorExtenso = ((deveColocarConjuncao ? conjuncao : string.Empty) + classeAnterior);

            return ordem + (EhClasseAnteriorTudoZero ? string.Empty : classeAnteriorPorExtenso);
        }

        public override int GetHashCode()
        {
            return ToString().GetHashCode();
        }
    }
}