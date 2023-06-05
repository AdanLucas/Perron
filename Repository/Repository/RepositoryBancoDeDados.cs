using Model.Emumerator;
using Model.Extension;
using Model.Interface.BancoDeDados;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Dapper;

namespace Repository.Repository
{
    public class RepositoryBancoDeDados : IRepositoryVerificacaoBancoDedados
    {

        DbSession _session;

        string NomeBaseCadastrada = CriandoBaseSql.nomePadrao;

        public static List<IScriptProcedure> ListaProcedure;
        public static List<IScriptFunction> ListaFunction;


        public RepositoryBancoDeDados()
        {
            ListaProcedure.GetListClassesImplementadas();
            ListaProcedure.GetListClassesImplementadas();

        }



        public bool CriarBaseDeDadosDefaut()
        {
            try
            {
                using (_session = new DbSession(ETipoConexao.Master))
                {

                    _session.Connection.Execute(CriandoBaseSql.ScriptBase());



                    if(validarExistenciaBancodeDadosConfigurado(_session))
                        return true;

                    else 
                        return false;

                }
            }
            catch
            {

                return false; ;
            }
        }
        public List<string> GetListaBancoInstancia()
        {
            using(_session = new DbSession(ETipoConexao.Master))
            {
                return _session.Connection.Query<string>(@"SELECT name FROM sys.databases").ToList();
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
             using( _session = new DbSession(ETipoConexao.Master))
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
