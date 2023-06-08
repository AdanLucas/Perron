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
    public static class ExtensionIScriptTabela
    {
        public static void ExecutarScriptCriacao(this IScriptTabela Script,DbSession session)
        {
            try
            {
                List<Type> ListaClasses = Assembly.GetExecutingAssembly().GetTypes().Where(t => t.GetInterfaces().Contains(typeof(IScriptTabela))).ToList();

                foreach (Type classe in ListaClasses)
                {
                    IScriptTabela tabela = (IScriptTabela)Activator.CreateInstance(classe);
                    ExecutarScript(session, tabela.Script);
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
