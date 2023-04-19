using System;
using System.Collections.Generic;
using Dapper;
using Repository.ScriptsDinamicos;

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