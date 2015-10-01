using System;

namespace EscritaPorExtenso.Lib.Helpers
{
    public static class ExtensoesDeType
    {
        public static T Construir<T>(this Type tipo, params object[] parametros)
        {
            return (T) tipo.GetConstructors()[0].Invoke(parametros);
        }
    }
}