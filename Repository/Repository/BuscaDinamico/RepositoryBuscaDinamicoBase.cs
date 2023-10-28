using Model.Interface.Repository;
using Model.Model;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Repository.Repository.BuscaDinamico
{
    public abstract class RepositoryBuscaDinamicoBase: IRepositoryBuscaDinamico
    {
        public Type TipoRepositorio { get; private set; }

        private DbSession _session;

        public RepositoryBuscaDinamicoBase(Type tipo)
        {
            TipoRepositorio = tipo;
        }

        protected abstract object MetodoObterPorId(IDbConnection Conn, int id);
        protected abstract IList MetodoObterTodos(IDbConnection conn);
        protected abstract EntidadeBuscaModel FiltrarPorEntidade(object obj);

        public EntidadeBuscaModel ObterPorId(int Id)
        {
            using (_session = new DbSession()) {

                var ret = MetodoObterPorId(_session.Connection, Id);
                return FiltrarPorEntidade(ret);
            }
        }
        public List<EntidadeBuscaModel> ObterTodos()

        {
            using (_session = new DbSession())
            {
                List<EntidadeBuscaModel> listaRetorno = new List<EntidadeBuscaModel>();
                var listaTipo = MetodoObterTodos(_session.Connection);

                foreach ( var tipo in listaTipo)
                {
                    var entidade = FiltrarPorEntidade(tipo);
                    listaRetorno.Add(entidade);
                }

                listaRetorno.Capacity = listaRetorno.Count;

                return listaRetorno;

            }
        }


    }
}
