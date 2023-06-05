using Model.Emumerator;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.CompilerServices;
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
            SelecionarTipoConexao(ETipoConexao.BaseConfigurada);
            Connection.Open();
        }
        catch
        {


        }
    }

    public DbSession(ETipoConexao tipo)
    {
        try
        {
            SelecionarTipoConexao(tipo);
            Connection.Open();
        }
        catch
        {


        }
    }

    public void Dispose() => Connection?.Dispose();

    private void SelecionarTipoConexao(ETipoConexao Tipo)
    {
        switch (Tipo)
        {
            case ETipoConexao.Master:
                Connection = new SqlConnection(ConfiguracoesGlobais.Instancia.StringConexaoMaster);
                break;

            case ETipoConexao.BaseConfigurada:
                Connection = new SqlConnection(ConfiguracoesGlobais.Instancia.StringConexaoDados);
                break;
        }
    }

}

