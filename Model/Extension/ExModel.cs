using Model.DTO;
using Model.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Model.Extension
{
    public static class ExModel
    {
        public static ProdutoDTO ConverterParaDTO(this ProdutoModel model) 
        {
            return new ProdutoDTO() { Id = model.Id, IdClasse = (int)model.Classe.Id, Descricao = model.Descricao, Ativo = model.Ativo };

        }
        public static List<ProdutoMercadoriaDTO> ObterProdutoMercadoriaDTO(this ProdutoModel model)
        {
            return  model.Ingredientes.Select(md => new ProdutoMercadoriaDTO() { Id = md.Id, Mercadoria = md.Mercadoria.Id, Produto = model.Id, Ativo = md.Ativo }).ToList();
        }
        public static ProdutoMercadoriaDTO ConverterParaDTO(this IngredienteModel model)
        {
           return new ProdutoMercadoriaDTO() { Id = model.Id, Mercadoria = model.Mercadoria.Id, Produto = model.Id, Ativo = model.Ativo };
        }
        public static List<DadosProdutoMercadoriaDTO> ObterDadosProdutoMercadoriaDTO(this ProdutoModel produto)
        {
            List<DadosProdutoMercadoriaDTO> listaDados = new List<DadosProdutoMercadoriaDTO>();

            foreach (var ingrediente in produto.Ingredientes)
            {
                var listaConvertida = ingrediente.DadosIngrediente.Select(dados => new DadosProdutoMercadoriaDTO() { IdProdutoMercadoria = (long)ingrediente.Id, Quantidade = dados.Quantidade, Tamanho = (long)dados.Tamanho.Id }).ToList();

                listaDados.AddRange(listaConvertida);
            }

            return listaDados;
        }

        public static List<DadosProdutoMercadoriaDTO> ConvertDadosparaDTO(this IngredienteModel ingrediente)
        {
            List<DadosProdutoMercadoriaDTO> listaDados = new List<DadosProdutoMercadoriaDTO>();

            foreach (var dados in ingrediente.DadosIngrediente)
            {
               var dadosDTO = new DadosProdutoMercadoriaDTO() { IdProdutoMercadoria = (long)ingrediente.Id, Quantidade = dados.Quantidade, Tamanho = (long)dados.Tamanho.Id };

                listaDados.Add(dadosDTO);
            }

            return listaDados;
        }
    }
}
