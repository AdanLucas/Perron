﻿using Dapper;
using GerenciandoBaseDedados.GerencaidorScript;
using Model.Emumerator;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Repository.Repository


{
    public class RepositoryBancoDeDados : IRepositoryVerificacaoBancoDedados
    {

        DbSession _session;

        string NomeBaseCadastrada = ConfiguracaoInicial.Instancia.Configuracao.ConexaoBancoDados.Banco;




        public RepositoryBancoDeDados()
        {



        }



        public void CriarBaseDeDadosDefaut()
        {
            try
            {
                CriarTabelasProcFunctionConstraint();
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }
        private void CriandoBase(DbSession _session, string sql)
        {
            try
            {
                var dbocommand = _session.Connection.CreateCommand();
                dbocommand.Connection = _session.Connection;
                dbocommand.Transaction = _session.Transaction;
                dbocommand.CommandText = sql;
                dbocommand.ExecuteNonQuery();
                dbocommand.Dispose();
            }
            catch (Exception ex)
            {
                throw ex;
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
            try
            {
                using (_session = new DbSession(ETipoConexao.Master))
                {

                    var UnitMastar = new UnitOfWork(_session);

                    GerenciandoScript.CriarBase(_session.Connection, NomeBaseCadastrada);

                    using (var session = new DbSession())
                    {
                        var Unit = new UnitOfWork(session);
                        try
                        {
                            Unit.BeginTran();
                            GerenciandoScript.IniciarTransacao(session.Connection);
                            GerenciandoScript.ExecutarCriacaoBase(session.Transaction);
                            Unit.Commit();

                        }
                        catch
                        {
                            UnitMastar.RollBack();
                            Unit.RollBack();
                        }
                    }
                }

            }
            catch
            {
                using (_session = new DbSession(ETipoConexao.Master))
                {
                    GerenciandoScript.DropDataBase(_session.Connection, NomeBaseCadastrada); 
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
            using (var _session = new DbSession(ETipoConexao.Master))
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
