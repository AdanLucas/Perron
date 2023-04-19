using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
namespace Repository.Repository
{



    public  class RepositoryClasse: IRepositoryClasse 
    {
        private void pc_cadastroClasse(DbSession Session, ClasseModel Classe)
        {
            try
            {
                Session.Connection.Execute("exec pc_cadastroClasse @id,@descricao,@ativo", param: new
                {
                    id = Classe.Id,
                    descricao = Classe.DescricaoClasse,
                    ativo = Classe.Ativo

                }, transaction: Session.Transaction);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        private List<ClasseModel> ScriptGetListaClasse(DbSession session )
        {
            return session.Connection.Query<ClasseModel>("select Id,Descricao as DescricaoClasse,Ativo from Classe").ToList();
        }
        private ClasseModel ScriptGetClassePorID(DbSession session,int id)
        {
            return session.Connection.Query<ClasseModel>($"select Id,Descricao as DescricaoClasse,Ativo from Classe where id = {id}").FirstOrDefault();
        }

        public ClasseModel GetItemPorID(int Id)
        {
            using (var session = new DbSession())
            {
                return this.ScriptGetClassePorID(session, Id);
            }
        }

        public List<ClasseModel> GetLista()
        {
            using (var Session = new DbSession())
            {
                return this.ScriptGetListaClasse(Session);
            }
        }

        public void Salvar(ClasseModel classe)
        {
            using (var Session = new DbSession())
            {
                this.pc_cadastroClasse(Session, classe);
            }
        }
      
    }
}
