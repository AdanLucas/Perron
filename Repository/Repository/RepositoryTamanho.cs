using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;

namespace Repository.Repository
{
    public class RepositoryTamanho : IRepositoryTamanho
    {

        #region Metodos Privados
        private void pc_cadastroTamanho(DbSession session, TamanhoModel tamanho)
        {
            session.Connection.Execute("exec pc_cadastroTamanho @id,@descricao,@qntPedacos,@ativo",
                param: new
                {
                    id = tamanho.Id,
                    descricao = tamanho.Descricao,
                    qntPedacos = tamanho.QntPedacos,
                    ativo = tamanho.Ativo
                }, transaction: session.Transaction);
        }
        #endregion

        #region metodos Publicos

        public List<TamanhoModel> GetListaTamanho()
        {
            using (var Session = new DbSession())
            {
                return Session.Connection.Query<TamanhoModel>("select * from Tamanho").ToList();
            }


        }

        public TamanhoModel GetTamanhoPorId(int id)
        {
            using (var session = new DbSession())
            {
                return session.Connection.Query<TamanhoModel>($"Select * from Tamanho where id = {id}").FirstOrDefault();
            }
        }

        public void SalvarTamanho(TamanhoModel tamanho)
        {
            using (var session = new DbSession())
            {
                pc_cadastroTamanho(session, tamanho);
            }
        } 

        #endregion

    }
}
