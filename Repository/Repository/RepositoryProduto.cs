using Dapper;
using Model.DTO;
using Model.Extension;
using Model.Model;
using Repository.ScriptBase.Tabela;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
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
        private long PC_CadastroProdutoMercadoria(ProdutoMercadoriaDTO produtoMercadoriaDTO)
        {
            try
            {
                return _session.Connection.Query<long>("Exec PC_CadastroProdutoMercadoria @Id,@IdProduto,@IdMercadoria,@Ativo", param: new
                {
                    produtoMercadoriaDTO.Id,
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

        private List<ProdutoMercadoriaDTO> ObterProdutomercadoria(long? idProduto)
        {
           return _session.Connection.Query<ProdutoMercadoriaDTO>(@"select HAS.Id,Produto.id as Produto,Mercadoria.Id as Mercadoria,HAS.Ativo from Mercadoria as Mercadoria
                                                                     INNER JOIN Produto_has_Mercadoria AS HAS on (HAS.Mercadoria = Mercadoria.Id)
                                                                     INNER JOIN Produto on (HAS.Produto = Produto.Id)
                                                                     where Produto = @Produto and has.Ativo = 1",param: new {Produto = idProduto},transaction : _session.Transaction).ToList();
        }
        private List<DadosProdutoMercadoriaDTO> ObterDadosProdutoMercadoriaDTO(long? idProdutoMercadoriaDTO)
        {
            return _session.Connection.Query<DadosProdutoMercadoriaDTO>($"select IdProdutoMercadoria,Tamanho,Quantidade from DadosMercadoriaProduto where IdProdutoMercadoria = @id",param: new {Id = idProdutoMercadoriaDTO}).ToList();
        }
        private List<DadosIngredienteModel> ObterDadosMercadoriaModel(long? idProdutoMercadoria)
        {
            var dadosDTO = ObterDadosProdutoMercadoriaDTO(idProdutoMercadoria);

           return dadosDTO.Select(dto => new DadosIngredienteModel { Tamanho = ObterTamanho(dto.Tamanho), Quantidade = dto.Quantidade }).ToList();
        }
        private List<IngredienteModel> ObterIngredienteModel(long? idProduto)
        {
            var ingredienteDTO = ObterProdutomercadoria(idProduto);
             return  ingredienteDTO.Select(dto=>new IngredienteModel() {Id = dto.Id, Mercadoria = ObterMercadoria(dto.Mercadoria),DadosIngrediente = ObterDadosMercadoriaModel(dto.Id),Ativo = dto.Ativo}).ToList();
        }
        private ClasseModel ObterClasse(int IDClasse)
        {
            return _session.Connection.Query<ClasseModel>(@"select Id,Descricao as DescricaoClasse,Ativo from Classe where id = @Id", param: new {Id = IDClasse},transaction: _session.Transaction).FirstOrDefault();
        }
        private MercadoriaModel ObterMercadoria(long? Mercadoria)
        {
           return _session.Connection.Query<MercadoriaModel>(@"select Id,Descricao,TipoMercadoria,TipoMedida,Ativo from Mercadoria where Id = @id and Ativo = 1 ",param: new {Id = Mercadoria}).FirstOrDefault();
        }
        private TamanhoModel ObterTamanho(long? Tamanho)
        {
           return _session.Connection.Query<TamanhoModel>($"Select * from Tamanho where id = {Tamanho}").FirstOrDefault();
        }
        private List<IngredienteModel> ObterIngrediente(long? Produto) 
        {
            var listaDTO = ObterProdutomercadoria(Produto);

            var listaModel = new List<IngredienteModel>();

                                foreach (var dto in listaDTO) 
                                { 
                                      var model = new IngredienteModel();

                                      model.Mercadoria = ObterMercadoria(dto.Mercadoria);

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
            using (_session = new DbSession())
            {
                var sql = String.Format("Select Id,Descricao,IdClasse,Ativo from Produto where ativo in ({0})"
                                                                                                     , status.HasFlag(EStatusCadastro.Todos) ? "0,1" : status.HasFlag(EStatusCadastro.Ativo) ? "1" : "0");

                var listaDTO = _session.Connection.Query<ProdutoDTO>(sql).ToList();

               return listaDTO.Select(dto=>new ProdutoModel() {Id = dto.Id,Descricao = dto.Descricao,Classe = ObterClasse(dto.IdClasse),Ingredientes = ObterIngredienteModel(dto.Id),Ativo = dto.Ativo }).ToList();
            }

        }
        public void Salvar(ProdutoModel produto)
        {
            using ( _session = new DbSession())
            {
                var Unit = new UnitOfWork(_session);

                Unit.BeginTran();

                try
                {
                    produto.Id = PC_CadastroProduto(produto.ConverterParaDTO());

                    foreach (var produtoMercadoria in produto.Ingredientes)
                    {
                        var DTO = produtoMercadoria.ConverterParaDTO();
                        DTO.Produto = produto.Id;
                        produtoMercadoria.Id = PC_CadastroProdutoMercadoria(DTO);

                        foreach (var dadosDto in produtoMercadoria.ConvertDadosparaDTO())
                        {
                            PC_CadastroDadosProdutoMercadoria(dadosDto);
                        }
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
