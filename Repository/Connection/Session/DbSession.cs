using Model.Emumerator;
using System;
using System.Data;
using System.Data.SqlClient;


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
                Connection = new SqlConnection(ConfiguracaoInicial.Instancia.StringConexaoMaster);
                break;

            case ETipoConexao.BaseConfigurada:
                Connection = new SqlConnection(ConfiguracaoInicial.Instancia.StringConexaoDados);
                break;
        }
    }

}

