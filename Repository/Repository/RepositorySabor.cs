﻿using Dapper;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Repository.Repository
{
    public class RepositorySabor : IRepositoryProduto
    {

        #region Interfaces



        #endregion



        #region Metodos Privados
        private int pc_cadastroSabor(DbSession Session, ProdutoModel sabor)
        {
            return Session.Connection.Query<int>("exec pc_cadastroSabor @id,@descricao,@idClasse,@ativo",
                param: new
                {
                    id = sabor.Id,
                    descricao = sabor.Descricao,
                    idClasse = sabor.Classe.Id,
                    ativo = sabor.Ativo
                }, transaction: Session.Transaction).FirstOrDefault<int>();


        }
        private void CadastroEngredienteSabor(DbSession Session, long? IDsabor, MercadoriaModel Engrediente)
        {
            try
            {
                Session.Connection.Execute("Exec pc_cadastroSaborEngrediente @IDSabor,@IDEngrediente,@Ativo", param: new
                {
                    IDSabor = (int)IDsabor,
                    IDEngrediente = Engrediente.Id,
                    Ativo = Engrediente.Ativo
                }, transaction: Session.Transaction);

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }


        }
        private ClasseModel GetClassePorSabor(DbSession session, int IDClasse)
        {

            return session.Connection.Query<ClasseModel>($"Select * from Classe where id = {IDClasse}").FirstOrDefault();

        }
        private List<MercadoriaModel> GetListaEngredientePorSabor(DbSession session, long? IDSabor)
        {
            return session.Connection.Query<MercadoriaModel>($@"SELECT * FROM  FN_GetEngredientePorSabor ({IDSabor})").ToList();
        }
        #endregion



        #region Metodos Publicos
        public List<ProdutoModel> GetLista(EStatusCadastro status)
        {
            using (var session = new DbSession())
            {
                var Lista = session.Connection.Query<ProdutoModel>("Select * from Sabor").ToList();

                foreach (var item in Lista)
                {
                    long IDclasse = session.Connection.Query<int>($"Select IdClasse From Sabor where Id = {item.Id}").FirstOrDefault();
                    item.Classe = session.Connection.Query<ClasseModel>($"select Id,Descricao as DescricaoClasse,Ativo from Classe where id= {IDclasse}").FirstOrDefault();
                    item.Ingredientes = GetListaEngredientePorSabor(session, item.Id);
                }

                return Lista;

            }

        }

        public ProdutoModel GetItemPorID(int Id)
        {
            using (var session = new DbSession())
            {
                return session.Connection.Query<ProdutoModel>($"Select * from Sabor where id = {Id}").FirstOrDefault();
            }
        }

        public void Salvar(ProdutoModel sabor)
        {
            using (var Session = new DbSession())
            {
                var Unit = new UnitOfWork(Session);

                Unit.BeginTran();

                try
                {
                    sabor.Id = pc_cadastroSabor(Session, sabor);

                    foreach (var Engrediente in sabor.Ingredientes)
                    {
                        CadastroEngredienteSabor(Session, sabor.Id, Engrediente);
                    }

                    Unit.Commit();

                }
                catch
                {
                    Unit.RollBack();
                    throw new Exception("Ocorreu Um erro Ao Cadastrar Sabor");

                }



            }
        }

        #endregion
    }
}
