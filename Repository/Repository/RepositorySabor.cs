﻿using System;
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
            sabor.Id = (long)Session.Connection.Query<int>("pc_cadastroSabor @id,@descricao,@idClasse,@ativo",
                param: new
                {
                    id = sabor.Id,
                    descricao = sabor.Descricao,
                    idClasse = sabor.Classe.Id,
                    ativo = sabor.Ativo
                }, transaction: Session.Transaction).FirstOrDefault();


        }
        private void CadastroEngredienteSabor(DbSession Session,long IDsabor,EngredienteModel Engrediente)
        {
            try
            {
                Session.Connection.Execute("Exec pc_cadastroSaborEngrediente @IDSabor,@IDEngrediente,@Ativo", param: new
                {
                    IDSabor = (int)IDsabor,
                    IDEngrediente = Engrediente.Id,
                     Ativo = Engrediente.Ativo
                },transaction: Session.Transaction);

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }


        }
        private ClasseModel GetClassePorSabor(DbSession session,int IDClasse)
        {

            return session.Connection.Query<ClasseModel>($"Select * from Classe where id = {IDClasse}").FirstOrDefault();
            
        }
        private List<EngredienteModel> GetListaEngredientePorSabor(DbSession session, long IDSabor)
        {
           return session.Connection.Query<EngredienteModel>($"select * from Engrediente where id IN (select Engrediente from Sabor_has_Engrediente where Sabor = {IDSabor})").ToList();
        }
        #endregion



        #region Metodos Publicos

        public List<SaborModel> GetLista()
        {
            using (var session = new DbSession())
            {
                var Lista = session.Connection.Query<SaborModel>("Select * from Sabor").ToList();

                foreach (var item in Lista)
                {
                    long IDclasse = session.Connection.Query<int>($"Select IdClasse From Sabor where Id = {item.Id}").FirstOrDefault();
                    item.Classe = session.Connection.Query<ClasseModel>($"select Id,Descricao as DescricaoClasse,Ativo from Classe where id= {IDclasse}").FirstOrDefault();
                    item.Engredientes = GetListaEngredientePorSabor(session,item.Id);


                }

                return Lista;

            }

        }

        public SaborModel GetItemPorID(int Id)
        {
            using (var session = new DbSession())
            {
              return session.Connection.Query<SaborModel>($"Select * from Sabor where id = {Id}").FirstOrDefault();
            }
        }

        public void Salvar(SaborModel sabor)
        {
            using (var Session = new DbSession())
            {
                var Unit = new UnitOfWork(Session);

                Unit.BeginTran();

                try
                {
                   pc_cadastroSabor(Session, sabor);

                    foreach (var Engrediente in sabor.GetEngredientePorStatus(EStatusCadastro.Todos))
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