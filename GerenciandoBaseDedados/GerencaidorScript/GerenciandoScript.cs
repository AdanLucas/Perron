using Repository.GerenciadorScript;
using System;
using System.Data;

namespace GerenciandoBaseDedados.GerencaidorScript
{
    public static class GerenciandoScript
    {
        static IDbConnection _conn;

        private static ScriptCriacaoBase ScriptBase { get; set; }
        private static GerenciarScriptFunction Functions { get; set; }
        private static GerenciarScriptProcedeure Procedures { get; set; }
        private static GerenciarScritpConstraint Constraints { get; set; }
        private static GerenciarScriptTabela Tabelas { get; set; }



        public static void IniciarTransacao(IDbConnection conn)
        {
            _conn = conn;
            Functions = new GerenciarScriptFunction(_conn);
            Constraints = new GerenciarScritpConstraint(_conn);
            Tabelas = new GerenciarScriptTabela(_conn);
            Procedures = new GerenciarScriptProcedeure(_conn);
        }
        public static void CriarBase(IDbConnection connMaster, string nomeBase)
        {
            ScriptBase = new ScriptCriacaoBase(connMaster);
            ScriptBase.CriacaoBase(nomeBase);
        }
        public static void ExecutarCriacaoBase(IDbTransaction tran)
        {
            try
            {
                Tabelas.ExecutarScriptCriacao(tran);
                Constraints.ExecutarScriptCriacao(tran);
                Procedures.ExecutarScritpCriacao(tran);
                Functions.ExecutarScritpCriacao(tran);

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

    }
}
