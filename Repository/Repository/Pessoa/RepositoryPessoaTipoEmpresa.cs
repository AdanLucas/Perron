using System;
using System.CodeDom;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using Dapper;
using Model.Model;

namespace Repository.Repository
{
    public class RepositoryPessoaTipoEmpresa : RepositoryBaseTipoPessoa
    {
        protected override int Procedure(object cadastro)
        {
            var _cadastro = cadastro as EmpresaModel;
           return _session.Connection.Query<int>("exec pc_cadastroEmpresa @id,@ativo",param:new { _cadastro.Id,_cadastro.Ativo}).FirstOrDefault();
        }
        protected override object ScriptGetCadastroPorID(int Id)
        {
          return _session.Connection.Query<EmpresaModel>("SELECT * FROM EMPRESA WHERE ID = @ID", param: new { Id }).FirstOrDefault();
        }
        protected override List<T> ScriptGetListaCadastrado<T>()
        {
           return _session.Connection.Query<T>("SELECT * FROM EMPRESA").ToList();
        }

    }
}
    