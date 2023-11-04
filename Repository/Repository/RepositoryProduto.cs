using Dapper;
using Model.DTO;
using Model.Extension;
using Model.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using static System.Collections.Specialized.BitVector32;

namespace Repository.Repository
{
    public class RepositoryProduto : IRepositoryProduto
    {

        #region Interfaces

        private DbSession _session;

        #endregion



        #region Metodos Privados

        #region Procedures
        private int PC_CadastroProduto(ProdutoDTO produto)
        {
            return _session.Connection.Query<int>("exec pc_cadastroProduto @id,@descricao,@idClasse,@ativo",
                param: new
                {
                    id = produto.Id,
                    descricao = produto.Descricao,
                    idClasse = produto.IdClasse,
                    ativo = produto.Ativo
                }, transaction: _session.Transaction).FirstOrDefault<int>();


        }
        private int PC_CadastroProdutoMercadoria(ProdutoMercadoriaDTO produtoMercadoriaDTO)
        {
            try
            {
                return _session.Connection.Query<int>("Exec PC_CadastroProdutoMercadoria @IdProduto,@IdMercadoria,@Ativo", param: new
                {
                    IdProduto = produtoMercadoriaDTO.Produto,
                    IdMercadoria = produtoMercadoriaDTO.Mercadoria,
                    produtoMercadoriaDTO.Ativo
                }, transaction: _session.Transaction).FirstOrDefault();

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        private void PC_CadastroDadosProdutoMercadoria(DadosProdutoMercadoriaDTO dadosDTO)
        {
            try
            {
                _session.Connection.Query<int>("Exec PC_CadastroDadosMercadoriaProduto @IdProdutoMercadoria,@Tamanho,@Quantidade"
                    , param: new
                    {
                        dadosDTO.IdProdutoMercadoria,
                        dadosDTO.Tamanho,
                        dadosDTO.Quantidade
                    }, transaction: _session.Transaction).FirstOrDefault();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        } 
        #endregion

        private ClasseModel ObterClasse(int IDClasse)
        {
            return _session.Connection.Query<ClasseModel>($"Select * from Classe where id = {IDClasse}").FirstOrDefault();
        }
        private MercadoriaModel ObterMercadoria(long? Mercadoria)
        {
           return _session.Connection.Query<MercadoriaModel>($"Select * from Mercadoria where Id = {Mercadoria}").FirstOrDefault();
        }
        private TamanhoModel ObterTamanho(long? Tamanho)
        {
           return _session.Connection.Query<TamanhoModel>($"Select * from Tamanho where id = {Tamanho}").FirstOrDefault();
        }
        private List<ProdutoMercadoriaDTO> ObterProdutomercadoria(long? idProduto)
        {
           return _session.Connection.Query<ProdutoMercadoriaDTO>($"SELECT * FROM PRODUTO_HAS_MERCADORIA WHERE PRODUTO = {idProduto} AND ATIVO = 1").ToList();
        }
        private List<DadosProdutoMercadoriaDTO> ObterDadosProdutoMercadoriaDTO(long? idProdutoMercadoriaDTO)
        {
            return _session.Connection.Query<DadosProdutoMercadoriaDTO>($"Select * from DadosProdutoMercadoria where IdProdutoMercadoria = {idProdutoMercadoriaDTO}").ToList();
        }
        private List<IngredienteModel> ObterIngrediente(long? Produto) 
        {
            var listaDTO = ObterProdutomercadoria(Produto);

            var listaModel = new List<IngredienteModel>();

                                foreach (var dto in listaDTO) 
                                { 
                                      var model = new IngredienteModel();

                                      model.Ingrediente = ObterMercadoria(dto.Mercadoria);

                                      var listadadoDTO = ObterDadosProdutoMercadoriaDTO((int)dto.Id);

                                      var listaDados = new List<DadosIngredienteModel>();

                                      foreach (var dadoDTO in listadadoDTO)
                                      {
                                          var dados = new DadosIngredienteModel();

                                          dados.Tamanho = ObterTamanho(dadoDTO.Tamanho);
                                          dados.Quantidade = dadoDTO.Quantidade;

                                          listaDados.Add(dados);
                                      }


                                    listaModel.Add(model);
                                }

            return listaModel;

        }
        private ProdutoModel ObterProdutoModel(ProdutoDTO dto)
        {
            var produtoModel = new ProdutoModel();
            produtoModel.Id = dto.Id;
            produtoModel.Descricao = dto.Descricao;
            produtoModel.Classe = ObterClasse(dto.IdClasse);
            produtoModel.Ingredientes = ObterIngrediente((int)dto.Id);

            return produtoModel;
        }
        #endregion

        #region Metodos Publicos
        public List<ProdutoModel> GetLista(EStatusCadastro status)
        {
            using (var session = new DbSession())
            {
                var Lista = session.Connection.Query<ProdutoDTO>("Select * from Produto where ativo = 1").ToList();
                return Lista.Select(dto=> ObterProdutoModel(dto)).ToList();
            }

        }
        

   

        public void Salvar(ProdutoModel produto)
        {
            using (var Session = new DbSession())
            {
                var Unit = new UnitOfWork(Session);

                Unit.BeginTran();

                try
                {
                    produto.Id = PC_CadastroProduto(produto.ConverterParaDTO());

                    foreach (var Engrediente in produto.ObterProdutoMercadoriaDTO())
                    {
                        PC_CadastroProdutoMercadoria(Engrediente);
                    }

                    foreach (var Engrediente in produto.ObterDadosProdutoMercadoriaDTO())
                    {
                        PC_CadastroDadosProdutoMercadoria(Engrediente);
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

        public ProdutoModel GetItemPorID(int Id)
        {

            using (_session = new DbSession())
            {
                var dto = _session.Connection.Query<ProdutoDTO>($"Select * from Produto where id = {Id}").First();

                return ObterProdutoModel(dto);
            }
            
        }

        #endregion
    }
}
