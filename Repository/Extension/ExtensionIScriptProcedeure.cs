using Dapper;
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
        public static void ExecutarScritpCriacao(this IScriptProcedure script,DbSession session) 
        {
            try
            {
                List<Type> ListaClasses = Assembly.GetExecutingAssembly().GetTypes().Where(t => t.GetInterfaces().Contains(typeof(IScriptProcedure))).ToList();

                foreach (Type classe in ListaClasses)
                {
                    IScriptProcedure Procedure = (IScriptProcedure)Activator.CreateInstance(classe);

                    if (!ValidarGUID(session,Procedure.GUID))
                    {
                        ExecutarScript(session, Procedure.ScriptPrcedured);

                    }
                }
            }
            catch (Exception ex)
            {
                
                session.Transaction.Rollback();
                throw ex;
            }

        }
        private static void ExecutarScript(DbSession session, string Script)
        {
            session.Connection.Execute(Script, transaction: session.Transaction);
        }
        private static bool ValidarGUID(DbSession session, string Guid)
        {
            return false;
        }


    }
}
