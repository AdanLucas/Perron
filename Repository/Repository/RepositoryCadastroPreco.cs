using Dapper;
using Model.DTO;
using Repository.ScriptBase.Tabela;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Repository.Repository
{
    public class RepositoryCadastroPreco : IRepositoryPreco
    {
        #region Metodos Privados
        
        DbSession _session;

        private TamanhoModel ObterTamanhoModel(PrecoDTO dto)
        {
           return _session.Connection.Query<TamanhoModel>(String.Format(@"select Id,Descricao,Quantidade,TipoQuantidade,Ativo from Tamanho where id = {0}", dto.IdTamanho)).FirstOrDefault();
        }
        private PrecoModel ConverterPrecoModel(PrecoDTO dto)
        {
            return new PrecoModel() { Id = dto.Id, Ativo = dto.Ativo,Preco = dto.Preco,Tamanho = ObterTamanhoModel(dto) };
        }    
         
        private Int64 PC_CadastroPreco(PrecoModel preco)
        {
           return _session.Connection.Query<int>("PC_CadastroPreco @Id,@IDTamanho,@Preco,@Ativo", param: new
            {
                preco.Id,
                IDTamanho = preco.Tamanho.Id,
                preco.Preco,
                preco.Ativo
            }, transaction: _session.Transaction).FirstOrDefault();
        }
        #endregion

        #region Metodos Publicos
        public List<PrecoModel> GetListaPreco(EStatusCadastro status)
        {
            using (_session = new DbSession())
            {
                List<PrecoModel> listaPreco = _session.Connection.Query<PrecoDTO>("Select * from Preco").ToList().Select(dto => ConverterPrecoModel(dto)).ToList();

                if (EStatusCadastro.Todos.Equals(status))
                {
                    return listaPreco;

                    
                }
                else
                {
                    bool ret = EStatusCadastro.Ativo.Equals(status);

                    return listaPreco.Where(lst=>lst.Ativo.Equals(ret)).ToList();
                }

                 

            }
        }
        private void SalvarVinculoPrecoClasse(Int64? idClasse,Int64? IdPreco)
        {
            var sql = String.Format(@"Insert INTO Classe_has_preco (Idclasse,IdPreco)
                                                                        Values ({0},{1})", idClasse, IdPreco);

            _session.Connection.Execute(sql, transaction: _session.Transaction);
        }
        public List<PrecoModel> GetListaPrecoPorClasse(int IDClasse)
        {
            using (_session = new DbSession())
            {
                var ListaPreco = new List<PrecoModel>();

                try
                {
                    ListaPreco = _session.Connection.Query<PrecoModel>("Select * from Preco where Ativo = 1 And IDClasse = IDClasse", param: new { IDClasse }).ToList();
                }
                catch (Exception ex)
                {
                    throw ex;
                }

                return ListaPreco;
            }
        }
        public void SalvarListaPreco(params object[] parametro)
        {
            using ( _session = new DbSession())
            {
                var UnitOfWork = new UnitOfWork(_session);
                UnitOfWork.BeginTran();

                List<PrecoModel> ListaPreco = parametro[0] as List<PrecoModel>;
                ClasseModel Classe = parametro.Length > 1 ? parametro[1] as ClasseModel : null;


                try
                {
                    foreach (var Item in ListaPreco)
                    {
                        Item.Id = PC_CadastroPreco(Item);

                        if(Classe != null)
                        {
                            SalvarVinculoPrecoClasse(Classe.Id, Item.Id);
                        }
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
                    PC_CadastroPreco(preco);
                }
                catch (Exception ex)
                {
                    throw ex;
                }


            }
        }
        public void RemoverTodosVinculoClassePreco(long? IdClasse)
        {
            using (_session = new DbSession())
            {

                _session.Connection.Execute($"DELETE FROM Classe_has_Preco WHERE IdClasse = {IdClasse}");
            }
        }

        public void RemoverVinculoPrecoClasse(long? IdClasse, long? IdPreco)
        {
            using (_session = new DbSession())
            {
                _session.Connection.Execute($"DELETE FROM Classe_has_Preco WHERE IdClasse = {IdClasse} AND IdPreco = {IdPreco}");
            }
        }
        #endregion

    }
}
