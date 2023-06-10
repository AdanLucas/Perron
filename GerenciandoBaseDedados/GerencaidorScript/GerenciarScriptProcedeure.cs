using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Repository.GerenciadorScript
{
    public class GerenciarScriptProcedeure : ScriptBase
    {

        public GerenciarScriptProcedeure(IDbConnection conn):base(conn) { }  


        private readonly List<Type> listaClasses = Assembly.GetExecutingAssembly().GetTypes().Where(t => t.GetInterfaces().Contains(typeof(IScriptProcedure))).ToList();
        private IScriptProcedure procedure;

        public  void ExecutarScritpCriacao(IDbTransaction tran) 
        {
            try
            {
                foreach (Type classe in listaClasses)
                {
                    procedure = (IScriptProcedure)Activator.CreateInstance(classe);
                    ExecutarScript(tran,procedure.ScriptPrcedured);
                    
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
