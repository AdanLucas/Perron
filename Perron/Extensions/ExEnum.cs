using Model.AtribulteClasses;
using Perron.TelaBusca.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Perron.Extensions
{
    public static class ExEnum
    {
        public static Type GetTipoBuscar(this ETipoBusca tipo)
        {
            FieldInfo elemento = tipo.GetType().GetField(tipo.ToString());

            if (elemento != null)
            {
                object[] custons = elemento.GetCustomAttributes(typeof(AtributoTipoBusca), false);

                return custons.Length == 0 ? null : ((AtributoTipoBusca)custons[0]).Tipo;

            }
            return null;
        }
    }
}
