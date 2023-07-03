using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using Model.Model;

namespace Repository.Repository
{
    public class RepositoryPessoa : RepositoryBaseTipoPessoa
    {
        protected override int Procedure(object cadastro)
        {
            PessoaModel pessoa = (PessoaModel)cadastro;

            return _session.Connection.Query<int>("EXEC PC_CadastroPessoa @Id,@Nome,@Sobrenome,@CpfCnpj,@Telefone,@Tipo,@Ativo", param: new { pessoa.Id, pessoa.Nome, pessoa.Sobrenome, pessoa.CpfCnpj, pessoa.Telefone, pessoa.Tipo, pessoa.Ativo}).FirstOrDefault();
        }
        protected override object ScriptGetCadastroPorID(int Id)
        {
            return _session.Connection.Query<object>("SELECT * FROM PESSOA WHERE ID = @ID",param: new {Id}).FirstOrDefault();
        }
        protected override IList ScriptGetListaCadastrado()
        {
           return _session.Connection.Query<object>("SELECT * FROM PESSOA").ToList();
        }
    }
}
