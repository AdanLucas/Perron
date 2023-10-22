using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Perron.Extensions
{
    public static class ExLista
    {
        public static List<T> Converter<T>(this List<object> entrada)
        {
           return entrada.Select(x => (T)x).ToList();
        }
        public static T ObterUnico<T>(this List<object> entrada)
        {
            if (entrada.Count == 1)
                    return entrada.Select(x => (T)x).FirstOrDefault();

            else return default;
        }

    }
}
