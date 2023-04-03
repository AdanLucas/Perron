using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;

namespace Repository.Repository
{
    public class RepositorySabor : IRepositorySabor
    {

        #region Interfaces

       

        #endregion

     

        #region Metodos Privados

        private void pc_cadastroSabor(DbSession Session,SaborModel sabor)
        {
            Session.Connection.Execute("pc_cadastroSabor @id,@descricao,@idClasse,@ativo",
                param: new
                {
                    id = sabor.Id,
                    descricao = sabor.Descricao,
                    idClasse = sabor.classe.Id,
                    ativo = sabor.Ativo 
                },transaction: Session.Transaction);


        }

       
        private List<EngredienteModel> GetListaEngredientePorSabor(DbSession session, int IDSabor)
        {
           return session.Connection.Query<EngredienteModel>($"select * from Engrediente where id IN (select Engrediente from Sabor_has_Engrediente where Sabor = {IDSabor})").ToList();
        }
        private ClasseModel GetClassePorSabor(DbSession session,int IDClasse)
        {

            session.Connection.Query<ClasseModel>($"Select * from Classe where id = {IDClasse}").FirstOrDefault();

            return null;
        }
        
        #endregion



        #region Metodos Publicos

        public List<SaborModel> GetListaSabor(EStatusCadastro statusCadastro)
        {
            string where = "";
            string sql = $"Select * from Sabor {where}";

            switch (statusCadastro)
            {
                case EStatusCadastro.Todos:

                    where = "";

                    break;
                case EStatusCadastro.Ativo:

                    where = "where Ativo = 1";

                    break;
                case EStatusCadastro.Inativo:

                    where = "where Ativo = 0";

                    break;
                default:
                    break;
            }

            using (var session = new DbSession())
            {
                var Lista =  session.Connection.Query<SaborModel>(sql).ToList();

                foreach (var item in Lista)
                {
                    int idClasse 



                }

            }
        }

        public SaborModel GetSaborPorId(int Id)
        {
            using (var session = new DbSession())
            {
              return session.Connection.Query<SaborModel>($"Select * from Sabor where id = {Id}").FirstOrDefault();
            }
        }

        public void SalvarSabor(SaborModel sabor)
        {
            using (var Session = new DbSession())
            {
                pc_cadastroSabor(Session, sabor);
            }
        } 

        #endregion
    }
}
