using Model.Model;
using Repository.ScriptBase.Tabela;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Text;
using System.CodeDom;

namespace Repository.Repository.BuscaDinamico
{

    internal class RepositoryBuscaTamanho : RepositoryBuscaDinamicoBase
    {
        public RepositoryBuscaTamanho() : base(typeof(TamanhoModel)){}

        protected override EntidadeBuscaModel FiltrarPorEntidade(object obj)
        {
            TamanhoModel tamanho = obj as TamanhoModel;

            return new EntidadeBuscaModel() { Descricao = $"{tamanho.Descricao} - {tamanho.DescricaoQuantidade}", DataItem = tamanho };
        }

        protected override object MetodoObterPorId(IDbConnection Conn, int id)
        {
            throw new NotImplementedException();
        }

        protected override IList MetodoObterTodos(IDbConnection conn)
        {
           return FactoryRepository.Tamanho().GetListaTamanho(EStatusCadastro.Ativo);
        }
    }
}
