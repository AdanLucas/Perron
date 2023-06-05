using Model.Interface.BancoDeDados;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Model.Extension
{
    public static class ExtensionICriptFunction
    {
        public static void GetListClassesImplementadas(this List<IScriptFunction> list)
        {
            List<Type> ListaClasses = Assembly.GetExecutingAssembly().GetTypes().Where(t => t.GetInterfaces().Contains(typeof(IScriptFunction))).ToList();

            foreach (Type classe in ListaClasses)
            {
                IScriptFunction Function = (IScriptFunction)Activator.CreateInstance(classe);

                list.Add(Function);
            }

        }
    }
}
