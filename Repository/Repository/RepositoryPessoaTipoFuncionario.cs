using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;

namespace Repository.Repository
{
    public class RepositoryPessoaTipoFuncionario : RepositoryBaseTipoPessoa
    {
        protected override int Procedure(object cadastro)
        {
            FuncionarioModel _funcionario = (FuncionarioModel)cadastro;
                                     return _session.Connection.Query<int>("EXEC PC_CadastroPessoaTipoFuncionario @id,@DataAdimissao,@Salario,@Ativo"
                                                                                    ,param: new { _funcionario.Id,_funcionario.DataAdimissao, _funcionario.Salario,_funcionario.Ativo}
                                                                                                                                                                             ).FirstOrDefault();
        }
        protected override object ScriptGetCadastroPorID(int Id)
        {
           return _session.Connection.Query<FuncionarioModel>("select * from PessaTipoFuncionario where id = @Id",param: new {Id}).FirstOrDefault();
        }
        protected override IList ScriptGetListaCadastrado()
        {
            return _session.Connection.Query<FuncionarioModel>("select * from PessaTipoFuncionario").ToList();
        }
    }
}
