using Dapper;
using Repository.ScriptsDinamicos;
using System.Collections.Generic;

public class RepositoryDinamico<T>
{



    public List<T> GetLista()
    {
        using (var Session = new DbSession())
        {
            var scrip = new ScriptsDinamicos<T>();

            return Session.Connection.Query<T>(scrip.GetScript()).AsList();
        }
    }
}