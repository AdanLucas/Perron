using Dapper;
using Model.Interface.BancoDeDados;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Model.Extension
{
    public static class ExtensionIScriptFunction 
    {
        public static void ExecutarScritpCriacao(this IScriptFunction script,DbSession session)
        {
            try
            {
                List<Type> ListaClasses = Assembly.GetExecutingAssembly().GetTypes().Where(t => t.GetInterfaces().Contains(typeof(IScriptFunction))).ToList();

                foreach (Type classe in ListaClasses)
                {
                    IScriptFunction Function = (IScriptFunction)Activator.CreateInstance(classe);

                    if (ValidarGUID(session, Function.GUID))
                    {
                        ExecutarScript(session, Function.ScriptFunction);
                    }
                }
            }
            catch (Exception ex)
            {
                session.Transaction.Rollback();
                throw ex;
            }

        }
        private static void ExecutarScript(DbSession session,string Script)
        {
            session.Connection.Execute(Script,transaction: session.Transaction);
        }
        private static bool ValidarGUID(DbSession session,string Guid)
        {
            return true;
        }

    }
}
