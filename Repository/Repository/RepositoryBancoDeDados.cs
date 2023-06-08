using Dapper;
using Model.Emumerator;
using Model.Extension;
using Model.Interface.BancoDeDados;
using System;
using System.Activities.Statements;
using System.Collections.Generic;
using System.Linq;
using System.Transactions;
namespace Repository.Repository
{
    public class RepositoryBancoDeDados : IRepositoryVerificacaoBancoDedados 
    {

        DbSession _session;

        string NomeBaseCadastrada = CriandoBaseSql.nomePadrao;

       


        public RepositoryBancoDeDados()
        {



        }



        public void CriarBaseDeDadosDefaut()
        {
            try
            {
                CriandoBase();
                CriarTabelasProcFunctionConstraint();

            }
            catch (Exception ex)
            {
                DropBase();
                throw ex;
            }

        }
        private void CriandoBase()
        {
            using (_session = new DbSession(ETipoConexao.Master))
            {
                try
                {
                    var dbocommand = _session.Connection.CreateCommand();
                    dbocommand.Connection = _session.Connection;
                    dbocommand.CommandText = CriandoBaseSql.ScriptBase();
                    dbocommand.ExecuteNonQuery();
                    dbocommand.Dispose();

                    if (!validarExistenciaBancodeDadosConfigurado(_session))
                        throw new Exception("Erro ao Criar Banco");

                    
                }
                catch (Exception ex)
                {
                    throw ex;
                }

            }

        }

        public List<string> GetListaBancoInstancia()
        {
            using (_session = new DbSession(ETipoConexao.Master))
            {
                return _session.Connection.Query<string>(@"SELECT name FROM sys.databases").ToList();
            }
        }

        private void CriarTabelasProcFunctionConstraint()
        {

            using (var session = new DbSession())
            {
                    var Unit = new UnitOfWork(session);
                try
                {

                    Unit.BeginTran();

                    IScriptTabela tabela = null;
                    IScriptConstraint constraint = null;
                    IScriptProcedure procedure = null;
                    IScriptFunction function = null;

                    tabela.ExecutarScriptCriacao(session);
                    constraint.ExecutarScriptCriacao(session);
                    procedure.ExecutarScritpCriacao(session);
                    function.ExecutarScritpCriacao(session);

                    //var usuario = CriandoBaseSql.CriandoUsuario();

                    //session.Connection.Execute(usuario, transaction: session.Transaction);

                    Unit.Commit();

                }
                catch (Exception ex)
                {
                    Unit.RollBack();
                    throw ex;
                }

            }


        }


        private void DropBase()
        {
            using (_session = new DbSession(ETipoConexao.Master))
            {
                try
                {
                    _session.Connection.Execute(CriandoBaseSql.DropDataBase());

                }
                catch (Exception ex)
                {

                    throw ex;
                }
            }
        }

        public bool ValidarConexaoComAInstancia()
        {
            try
            {
                _session = new DbSession(ETipoConexao.Master);

                _session.Dispose();

                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool validarExistenciaBancodeDadosConfigurado()
        {
            using (_session = new DbSession(ETipoConexao.Master))
            {
                return validarExistenciaBancodeDadosConfigurado(_session);
            }
        }
        private bool validarExistenciaBancodeDadosConfigurado(DbSession session)
        {
            return session.Connection.Query<bool>(
                                                  $@"DECLARE @RET BIT
                                                        IF(exists(SELECT 1 name FROM sys.databases where name = '{NomeBaseCadastrada}'))
                                                        BEGIN SET @RET =  1 END
                                                        ELSE BEGIN SET @RET = 0  END
                                                        SELECT @RET"
                                                        ).FirstOrDefault();
        }
    }
}
