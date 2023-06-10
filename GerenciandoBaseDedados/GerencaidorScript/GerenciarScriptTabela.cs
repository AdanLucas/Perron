using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;

namespace Repository.GerenciadorScript
{
    public class GerenciarScriptTabela : ScriptBase
    {

        public GerenciarScriptTabela(IDbConnection conn) : base(conn) { }


       private readonly List<Type> listaClasses = Assembly.GetExecutingAssembly().GetTypes().Where(t => t.GetInterfaces().Contains(typeof(IScriptTabela))).ToList();
       private  IScriptTabela tabela;

        public  void ExecutarScriptCriacao(IDbTransaction tran)
        {
            try
            {
                foreach (Type classe in listaClasses)
                {
                     tabela = (IScriptTabela)Activator.CreateInstance(classe);
                    ExecutarScript(tran,tabela.Script);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
    

    }
}
