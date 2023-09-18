using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Dapper;
using Model.Model;

namespace Repository.Repository
{
    public class RepositoryPessoaTipoCliente : RepositoryBaseTipoPessoa
    {
        protected override object ScriptGetCadastroPorID(int Id)
        {
            return _session.Connection.Query<ClienteModel>("SELECT * FROM CLIENTE WHERE ID = @Id", param: new { Id }).FirstOrDefault();
        }
        protected override int Procedure(object cadastro)
        {
            var _cadastro = cadastro as ClienteModel;
            return _session.Connection.Query<int>("exec pc_CadastroCliente @id,@Ativo", param: new { _cadastro.Id, _cadastro.Ativo }).FirstOrDefault();
        }
        protected override List<T> ScriptGetListaCadastrado<T>()
        {
            return _session.Connection.Query<T>("SELECT * FROM CLIENTE").ToList();
        }
    }
}
