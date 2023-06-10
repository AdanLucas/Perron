using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;

namespace Repository.GerenciadorScript
{
    public  class GerenciarScritpConstraint : ScriptBase
    {

        public GerenciarScritpConstraint(IDbConnection conn) : base(conn) { }


        private readonly List<Type> listaClasses =  Assembly.GetExecutingAssembly().GetTypes().Where(t => t.GetInterfaces().Contains(typeof(IScriptConstraint))).ToList();
        private IScriptConstraint constraint;
        public  void ExecutarScriptCriacao(IDbTransaction tran)
        {
            try
            {
                foreach (Type classe in listaClasses)
                {
                    constraint = (IScriptConstraint)Activator.CreateInstance(classe);
                    ExecutarScript(tran, constraint.Script);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
      

    }
}
