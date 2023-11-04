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
using Model.Interface.Repository;

namespace Repository.Repository.BuscaDinamico
{

    public class RepositoryBuscaTamanho : RepositoryBuscaDinamicoBase , IRepositoryBuscaDinamico
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
