using Model.Interface.Repository;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;

namespace Repository.Repository.BuscaDinamico
{
    public class RepositoryBuscaIngredientes : RepositoryBuscaDinamicoBase, IRepositoryBuscaDinamico
    {
        public Type TipoRepositorio { get { return typeof(IngredienteModel); } }

        protected override object MetodoObterPorId(IDbConnection conn, int id)
        {
            return conn.Query<object>($"Select ID,Descricao,TipoMedida from Mercadoria where Id = {id} ativo = 1").FirstOrDefault();
        }

        protected override object MetodoObterTodos(IDbConnection conn)
        {
           return conn.Query<object>("Select ID,Descricao,TipoMedida from Mercadoria where ativo = 1").ToList();
        }
    }
}
