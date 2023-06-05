﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class DbSession : IDisposable
{
    public IDbConnection Connection { get; set; }
    public IDbTransaction Transaction { get; set; }

    public DbSession()
    {
        try
        {
            Connection = new SqlConnection(ConfiguracoesGlobais.Instancia.StringConexaoDados);
            Connection.Open();
        }
        catch
        {


        }
    }

    public void Dispose() => Connection?.Dispose();

}
