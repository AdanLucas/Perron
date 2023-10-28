using Dapper;
using Model.Interface.Repository;
using Model.Model;
using System.Collections;
using System.Data;
using System.Linq;

namespace Repository.Repository.BuscaDinamico
{
    internal class RepositoryBuscaIngrediente : RepositoryBuscaDinamicoBase
    {
        public RepositoryBuscaIngrediente() : base(typeof(IngredienteModel)) { }

        protected override EntidadeBuscaModel FiltrarPorEntidade(object obj)
        {
            var ingrediente = new IngredienteModel();
            MercadoriaModel mercadoria = (MercadoriaModel)obj;
            ingrediente.Ingrediente = mercadoria;

            return new EntidadeBuscaModel() { Descricao = ingrediente.Ingrediente.Descricao, DataItem = ingrediente };
        }
        protected override object MetodoObterPorId(IDbConnection conn, int id)
        {
            var ret = conn.Query<MercadoriaModel>($"Select ID,Descricao,TipoMedida from Mercadoria where Id = {id} ativo = 1").FirstOrDefault();

            return new EntidadeBuscaModel() { Descricao = ret.Descricao, DataItem = ret };
        }
        protected override IList MetodoObterTodos(IDbConnection conn)
        {
            return conn.Query<MercadoriaModel>("Select ID,Descricao,TipoMedida from Mercadoria where ativo = 1").ToList();
        }
    }
}
