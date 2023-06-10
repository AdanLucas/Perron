using Repository.GerenciadorScript;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using Dapper;

namespace GerenciandoBaseDedados.GerencaidorScript
{
    public class GerenciandoScript
    {
        IDbConnection _conn;

        private ScriptCriacaoBase ScriptBase { get; set; }
        private GerenciarScriptFunction Functions { get; set; }
        private GerenciarScriptProcedeure Procedures { get; set; }
        private GerenciarScritpConstraint Constraints { get; set; }
        private GerenciarScriptTabela Tabelas { get; set; }

        public GerenciandoScript()
        {


        }

        public void IniciarTransacao(IDbConnection conn)
        {
            _conn = conn;

            Functions = new GerenciarScriptFunction(_conn);
            Constraints = new GerenciarScritpConstraint(_conn);
            Tabelas = new GerenciarScriptTabela(_conn);
            Procedures = new GerenciarScriptProcedeure(_conn);
        }
        public string ScriptCriacaoBase(string nomeBase)
        {
            ScriptBase = new ScriptCriacaoBase(nomeBase);

            return ScriptBase.CriacaoBase();
        }
        public void ExecutarCriacaoBase(IDbTransaction tran)
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
