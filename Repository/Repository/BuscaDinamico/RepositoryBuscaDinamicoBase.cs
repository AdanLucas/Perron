using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Repository.BuscaDinamico
{
    public abstract class RepositoryBuscaDinamicoBase
    {
        private DbSession _session;

        protected abstract object MetodoObterPorId(IDbConnection Conn, int id);
        protected abstract object MetodoObterTodos(IDbConnection conn);

        public object ObterPorId(int Id)
        {
            using (_session = new DbSession()) {

                return MetodoObterPorId(_session.Connection, Id);

            }
        }
        public object ObterTodos()
        {
            using (_session = new DbSession())
            {
                return MetodoObterTodos(_session.Connection);
            }
        }


    }
}
