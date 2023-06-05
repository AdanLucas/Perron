using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Model.Extension
{
    public static class ExtensionIScriptProcedeure
    {
        public static void GetListClassesImplementadas(this List<IScriptProcedure> list) 
        {
            List<Type> ListaClasses = Assembly.GetExecutingAssembly().GetTypes().Where(t => t.GetInterfaces().Contains(typeof(IScriptProcedure))).ToList();


            foreach (Type classe in ListaClasses)
            {
                IScriptProcedure Procedure = (IScriptProcedure)Activator.CreateInstance(classe);

                list.Add(Procedure);
            }

        }

    }
}
