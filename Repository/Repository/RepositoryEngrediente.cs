using Dapper;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Repository.Repository
{
    public class RepositoryEngrediente : IRepositoryEngrediente
    {


        #region Metodos Privados
        private void pc_cadastroEngrediente(DbSession session, IngredienteModel engrediente)
        {
            session.Connection.Execute("exec pc_cadastroMercadoria @id,@descricao,@tipoMedida,@ativo", param: new
            {
                id = engrediente.Id,
                descricao = engrediente.Descricao,
                tipoMedida = engrediente.TipoMedida,
                ativo = engrediente.Ativo
            }, transaction: session.Transaction);
        }
        #endregion



        #region metodos Publicos
        public List<IngredienteModel> GetListaEngredientePorSabor(int IDSabor)
        {
            using (var session = new DbSession())
            {
                return session.Connection.Query<IngredienteModel>($"select * from Mercadoria where id IN (select Engrediente from Sabor_has_Engrediente where Sabor = {IDSabor})").ToList();
            }
        }
        public IngredienteModel GetItemPorID(int Id)
        {
            using (var session = new DbSession())
            {
                return session.Connection.Query<IngredienteModel>($"select * From Mercadoria where Id = {Id}").FirstOrDefault();
            }
        }
        public List<IngredienteModel> GetLista(EStatusCadastro status)
        {
            using (var session = new DbSession())
            {
                return session.Connection.Query<IngredienteModel>("select * from Mercadoria").ToList();
            }
        }
        public List<EngredienteDTO> GetListaEngredienteDTO()
        {
            using (var Session = new DbSession())
            {
                return Session.Connection.Query<EngredienteDTO>("select id,Descricao, case Ativo when 1 then 'Ativo'  when 0 then 'Inativo' end Status  from Mercadoria").ToList();
            }
        }
        public void Salvar(IngredienteModel Item)
        {
            using (var session = new DbSession())
            {
                var UnitOfWork = new UnitOfWork(session);

                try
                {
                    pc_cadastroEngrediente(session, Item);
                }
                catch (Exception ex)
                {

                    throw ex;
                }


            }
        }
        public IngredienteModel GetEngredientePorId(int Id)
        {
            throw new NotImplementedException();
        }
        #endregion


    }
}
