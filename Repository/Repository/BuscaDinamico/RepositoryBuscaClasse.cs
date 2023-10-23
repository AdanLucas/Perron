using Dapper;
using Model.Model;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Repository.BuscaDinamico
{
    internal class RepositoryBuscaClasse : RepositoryBuscaDinamicoBase
    {
        public RepositoryBuscaClasse() : base(typeof(ClasseModel)) { }

        protected override EntidadeBuscaModel FiltrarPorEntidade(object obj)
        {
            ClasseModel entrada = (ClasseModel)obj;
            return new EntidadeBuscaModel() { Descricao = entrada.DescricaoClasse, DataItem = entrada };
        }

        protected override object MetodoObterPorId(IDbConnection Conn, int id)
        {
            return Conn.Query<ClasseModel>($"select Id,Descricao as DescricaoClasse,Ativo from Classe where Id= {id} Ativo = 1").FirstOrDefault();
        }

        protected override IList MetodoObterTodos(IDbConnection conn)
        {
            return conn.Query<ClasseModel>("select Id,Descricao as DescricaoClasse,Ativo from Classe where Ativo = 1").ToList();
        }
    }
}
