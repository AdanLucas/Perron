using Model.DTO;
using Model.Interface.Repository;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using System.Collections;
using Model.Model;

namespace Repository.Repository.BuscaDinamico
{
    public class RepositoryBuscaMercadoria : RepositoryBuscaDinamicoBase, IRepositoryBuscaDinamico
    {
        
        public RepositoryBuscaMercadoria() : base(typeof(MercadoriaDTO)) { }

        protected override EntidadeBuscaModel FiltrarPorEntidade(object obj)
        {
            throw new NotImplementedException();
        }

        protected override object MetodoObterPorId(IDbConnection Conn, int id)
        {
            return null;    
        }
        protected override List<object> MetodoObterTodos(IDbConnection conn)
        {
            return null;
        }

    }
}
