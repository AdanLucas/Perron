using Dapper;
using System.Data;
using System.Data.Common;

namespace Repository.GerenciadorScript
{
    public abstract class ScriptBase
    {
        IDbConnection _connection;

        public ScriptBase(IDbConnection connection)
        {
            _connection = connection;
        }

        protected void ExecutarScript(IDbTransaction tran,string Script)
        {
            _connection.Execute(Script,transaction: tran);
        }
        protected bool ValidarGUID(string Guid)
        {
            return true;
        }

        protected string ScriptConsulta(string GUID)
        {
            return $@"";
        }

    }
}
