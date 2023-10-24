using Dapper;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Repository.Repository
{
    public class RepositoryMercadoria : IRepositoryMercadoria
    {


        #region Metodos Privados
        private void pc_cadastroMercadoria(DbSession session, MercadoriaModel mercadoria)
        {
            session.Connection.Execute("exec pc_cadastroMercadoria @id,@descricao,@tipoMercadoria,@tipoMedida,@ativo", param: new
            {
                id = mercadoria.Id,
                descricao = mercadoria.Descricao,
                tipoMercadoria = mercadoria.TipoMercadoria,
                tipoMedida = mercadoria.TipoMedida,
                ativo = mercadoria.Ativo
            }, transaction: session.Transaction);
        }
        #endregion



        #region metodos Publicos
        public List<MercadoriaModel> GetListaMercadoriaPorProduto(int IDSabor)
        {
            using (var session = new DbSession())
            {
                return session.Connection.Query<MercadoriaModel>($"select * from Mercadoria where id IN (select Engrediente from Sabor_has_Engrediente where Sabor = {IDSabor})").ToList();
            }
        }
        public MercadoriaModel GetItemPorID(int Id)
        {
            using (var session = new DbSession())
            {
                return session.Connection.Query<MercadoriaModel>($"select * From Mercadoria where Id = {Id}").FirstOrDefault();
            }
        }
        public List<MercadoriaModel> GetLista(EStatusCadastro status)
        {
            using (var session = new DbSession())
            {
                return session.Connection.Query<MercadoriaModel>("select * from Mercadoria where ativo = 1").ToList();
            }
        }
        public void Salvar(MercadoriaModel Item)
        {
            using (var session = new DbSession())
            {
                var UnitOfWork = new UnitOfWork(session);

                try
                {
                    pc_cadastroMercadoria(session, Item);
                }
                catch (Exception ex)
                {

                    throw ex;
                }
            }
        }
        public MercadoriaModel GetMercadoriaPorId(int Id)
        {
            throw new NotImplementedException();
        }
        #endregion


    }
}
