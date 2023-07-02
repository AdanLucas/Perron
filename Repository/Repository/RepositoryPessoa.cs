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
    internal class RepositoryPessoa : IReposotiryTipoPessoa
    {



        private int PC_CadastroPessoa(DbSession session,PessoaModel Pessoa)
        {
           return session.Connection.Query<int>("exec PC_CadastroPessoa @Id,@Nome,@Sobrenome,@CpfCnpj,@Telefone,@Tipo,@Ativo"
                                                                 ,param: new {
                                                                     Pessoa.Id
                                                                    ,Pessoa.Nome
                                                                    ,Pessoa.Sobrenome
                                                                    ,Pessoa.CpfCnpj
                                                                    ,Pessoa.Telefone
                                                                    ,Pessoa.Tipo
                                                                    ,Pessoa.Ativo}
                                                                 ,transaction:session.Transaction).FirstOrDefault();
        }

        public object GetCadastroPorId(int Id)
        {
            using (var session = new DbSession())
            {
                return session.Connection.Query<PessoaModel>("SELECT * FROM PESSOA WHERE ID = @ID", param:new {Id}).FirstOrDefault();
            }

        }

        public IList GetLista()
        {
            using (var session = new DbSession())
            {
                return session.Connection.Query<PessoaModel>("Select * from Pessoal").ToList();
            }
        }

        public int Salvar(object cadastro)
        {
            using (var session = new DbSession())
            {
                try
                {
                    return PC_CadastroPessoa(session, cadastro as PessoaModel);
                }
                catch (Exception ex)
                {

                    throw ex;
                }
            }
        }

        public void SalvarLista(IList lista)
        {
            using (var session = new DbSession())
            {
                try
                {
                    foreach (var item in lista)
                    {
                        PC_CadastroPessoa(session, item as PessoaModel);
                    }
                }
                catch (Exception ex)
                {

                    throw ex;
                }

            }
        }
    }
}
