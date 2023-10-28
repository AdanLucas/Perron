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
using System.ComponentModel.Design;
using Repository.ScriptBase.Tabela;

namespace Repository.Repository.BuscaDinamico
{
    public class RepositoryBuscaMercadoria : RepositoryBuscaDinamicoBase, IRepositoryBuscaDinamico
    {


        public RepositoryBuscaMercadoria() : base(typeof(MercadoriaModel)) { }

        protected override EntidadeBuscaModel FiltrarPorEntidade(object obj)
        {
            MercadoriaModel ret = (MercadoriaModel)obj;
           return new EntidadeBuscaModel() {Descricao = ret.Descricao,DataItem = ret};
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
