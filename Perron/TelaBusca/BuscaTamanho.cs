using Model.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Perron.TelaBusca
{
    public class BuscaTamanho : TelaBuscaBase
    {

        public BuscaTamanho() : base(typeof(TamanhoModel)) {  } 

        protected override EntidadeBuscaModel CriandoListaGrid(object Entidade)
        {
            TamanhoModel tamanho = Entidade as TamanhoModel;

            return new EntidadeBuscaModel() { Descricao = $"{tamanho.Descricao} - {tamanho.DescricaoQuantidade}", DataItem = tamanho };
        }
    }
}
