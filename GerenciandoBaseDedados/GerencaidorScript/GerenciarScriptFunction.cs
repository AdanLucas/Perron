using Model.Interface.BancoDeDados;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;

namespace Repository.GerenciadorScript
{
    public  class GerenciarScriptFunction : ScriptBase
    {

        public GerenciarScriptFunction(IDbConnection conn) : base(conn) {}


        private readonly List<Type> listaClasses = Assembly.GetExecutingAssembly().GetTypes().Where(t => t.GetInterfaces().Contains(typeof(IScriptFunction))).ToList();
        IScriptFunction function;
        
        
        public void ExecutarScritpCriacao(IDbTransaction tran)
        {
            try
            {
                foreach (Type classe in listaClasses)
                {
                    function = (IScriptFunction)Activator.CreateInstance(classe);

                    if (ValidarGUID(function.GUID))
                    {
                        ExecutarScript(tran,function.ScriptFunction);
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

    }
}
