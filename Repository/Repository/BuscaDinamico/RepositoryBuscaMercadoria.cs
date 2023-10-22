using Model.DTO;
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
    public class RepositoryBuscaMercadoria : RepositoryBuscaDinamicoBase, IRepositoryBuscaDinamico
    {
        public Type TipoRepositorio { get { return typeof(MercadoriaDTO); } }

        protected override object MetodoObterPorId(IDbConnection Conn, int id)
        {
            return null;
        }
        protected override object MetodoObterTodos(IDbConnection conn)
        {
            return null;
        }

    }
}
