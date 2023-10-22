using Dapper;
using Model.Model;
using System;
using System.Activities.Statements;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Repository.Repository
{
    public class RepositoryPessoa : RepositoryBaseTipoPessoa
    {

        private void PC_CadatroEndereco(Int64? IdPessoa ,EnderecoModel endereco)
        {
            _session.Connection.Execute("PC_CadastroEndereco @ID,@IDPessoa,@Descricao,@Rua,@Numero, @Bairro,@Cidade,@Ativo"
                , param: new {ID = endereco.Id,IdPessoa,endereco.Descricao,endereco.Rua,endereco.Numero,endereco.Bairro,endereco.Cidade,endereco.Ativo});
        }

        protected override int Procedure(object cadastro)
        {
            PessoaModel pessoa = (PessoaModel)cadastro;

            pessoa.Id = _session.Connection.Query<int>("EXEC PC_CadastroPessoa @Id,@Nome,@Sobrenome,@CpfCnpj,@Telefone,@Tipo,@Ativo", param: new { pessoa.Id, pessoa.Nome, pessoa.Sobrenome, pessoa.CpfCnpj, pessoa.Telefone, pessoa.Tipo, pessoa.Ativo }).FirstOrDefault();

            if (pessoa.Enderecos != null && pessoa.Enderecos.Count > 0)
            {
                foreach (var endereco in pessoa.Enderecos)
                {
                    PC_CadatroEndereco(pessoa.Id, endereco);
                }
            }

            return (int)pessoa.Id;

        }
        protected override object ScriptGetCadastroPorID(int Id)
        {
            return _session.Connection.Query<object>("SELECT * FROM PESSOA WHERE ID = @ID", param: new { Id }).FirstOrDefault();
        }
        protected override List<T> ScriptGetListaCadastrado<T>()
        {
            var lista = _session.Connection.Query<T>("SELECT * FROM PESSOA").ToList();

            foreach (var item in lista as List<PessoaModel>)
            {
                item.Enderecos = _session.Connection.Query<EnderecoModel>("SELECT * FROM ENDERECO WHERE IDPESSOA = @ID",param: new {ID = item.Id}).ToList();
            }
            
            

            return lista;
        }
    }
}
