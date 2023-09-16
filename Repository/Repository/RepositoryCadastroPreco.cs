using Dapper;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Repository.Repository
{
    public class RepositoryCadastroPreco : IRepositoryPreco
    {
        #region Metodos Privados
        private void SetarPropriedades(DbSession session, PrecoModel preco)
        {
            try
            {
                preco.Tamanho = session.Connection.Query<TamanhoModel>($@"SELECT tm.* FROM Tamanho AS tm JOIN Preco AS pr ON (pr.idTamanho = tm.Id) WHERE pr.id = {preco.Id}").FirstOrDefault();
                preco.Classe = session.Connection.Query<ClasseModel>($@"SELECT cl.* FROM Classe AS cl JOIN Preco AS pr ON (pr.idClasse = cl.Id) WHERE pr.id = {preco.Id}").FirstOrDefault();
            }
            catch (Exception ex)
            {
                throw ex;
            }


        }
        private void SetarPropriedadeLista(DbSession Session, List<PrecoModel> lista)
        {
            foreach (var preco in lista)
            {
                SetarPropriedades(Session, preco);
            }
        }
        private void PC_CadastroPreco(DbSession session, PrecoModel preco)
        {
            session.Connection.Execute("PC_CadastroPreco @Id,@IdClasse,@IDTamanho,@Preco,@Ativo", param: new
            {
                preco.Id
                                                                                                                                  ,
                IdClasse = preco.Classe.Id
                                                                                                                                  ,
                IDTamanho = preco.Tamanho.Id
                                                                                                                                  ,
                preco.Preco
                                                                                                                                  ,
                preco.Ativo
            }, transaction: session.Transaction);
        }
        #endregion

        #region Metodos Publicos
        public List<PrecoModel> GetListaPreco(EStatusCadastro status)
        {
            using (var session = new DbSession())
            {
                List<PrecoModel> listaPreco;

                if (EStatusCadastro.Todos.Equals(status))
                {
                    listaPreco = session.Connection.Query<PrecoModel>("Select * from Preco").ToList();
                }
                else
                {
                    bool ret = EStatusCadastro.Ativo.Equals(status);

                    listaPreco = session.Connection.Query<PrecoModel>("Select * from Preco where Ativo = ret", param: new { ret }).ToList();
                }

                foreach (var item in listaPreco)
                {
                    SetarPropriedades(session, item);
                }

                return listaPreco;

            }
        }
        public List<PrecoModel> GetListaPrecoPorClasse(int IDClasse)
        {
            using (var session = new DbSession())
            {
                var ListaPreco = new List<PrecoModel>();

                try
                {
                    ListaPreco = session.Connection.Query<PrecoModel>("Select * from Preco where Ativo = 1 And IDClasse = IDClasse", param: new { IDClasse }).ToList();
                    SetarPropriedadeLista(session, ListaPreco);

                }
                catch (Exception ex)
                {
                    throw ex;
                }

                return ListaPreco;
            }
        }
        public void SalvarListaPreco(List<PrecoModel> Lista)
        {
            using (var session = new DbSession())
            {
                var UnitOfWork = new UnitOfWork(session);

                UnitOfWork.BeginTran();

                try
                {
                    foreach (var Item in Lista)
                    {
                        PC_CadastroPreco(session, Item);
                    }

                    UnitOfWork.Commit();

                }
                catch (Exception ex)
                {
                    UnitOfWork.RollBack();
                    throw ex;
                }
            }
        }
        public void SalvarPreco(PrecoModel preco)
        {
            using (var session = new DbSession())
            {
                try
                {
                    PC_CadastroPreco(session, preco);
                }
                catch (Exception ex)
                {
                    throw ex;
                }


            }
        }
        #endregion

    }
}
