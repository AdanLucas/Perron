using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;

namespace Repository.Repository
{
    public class RepositoryEngrediente : IRepositoryEngrediente
    {
  

        #region Metodos Privados

        private void pc_cadastroEngrediente(DbSession session, EngredienteModel engrediente)
        {
            session.Connection.Execute("exec pc_cadastroEngrediente @id,@descricao,@ativo", param: new
            {
                id = engrediente.Id,
                descricao = engrediente.Descricao,
                ativo = engrediente.Ativo
                                            }, transaction: session.Transaction);
        }

        #endregion

        #region metodos Publicos

        public List<EngredienteModel> GetListaEngredientePorSabor(int IDSabor)
        {
            using (var session = new DbSession())
            {
                return session.Connection.Query<EngredienteModel>($"select * from Engrediente where id IN (select Engrediente from Sabor_has_Engrediente where Sabor = {IDSabor})").ToList();
            }
        }

        public EngredienteModel GetEngredientePorId(int Id)
        {
            throw new NotImplementedException();
        }

        public List<EngredienteModel> GetListaEngrediente(EStatusCadastro statusCadastro)
        {
            var where = "";
            var sql = $"select * from Engrediente {where}";

            switch (statusCadastro)
            {

                case EStatusCadastro.Ativo:

                    where = "where Ativo = 1";

                    break;
                case EStatusCadastro.Inativo:

                    where = "where Ativo = 0";

                    break;

            }

            using (var session = new DbSession())
            {

                return session.Connection.Query<EngredienteModel>(sql).ToList();

            }


        }

        public void SalvarEngrediente(EngredienteModel Engrediente)
        {
            throw new NotImplementedException();
        }

        public List<EngredienteDTO> GetListaEngredienteDTO()
        {
            using (var Session = new DbSession())
            {
                return Session.Connection.Query<EngredienteDTO>("select id,Descricao, case Ativo when 1 then 'Ativo'  when 0 then 'Inativo' end Status  from Engrediente").ToList();
            }
        }

        #endregion


    }
}
