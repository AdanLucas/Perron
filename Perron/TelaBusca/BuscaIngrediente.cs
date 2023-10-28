using Model.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Perron.TelaBusca
{
    public class BuscaIngrediente : TelaBuscaBase
    {
        public BuscaIngrediente() : base(typeof(IngredienteModel)) { }

        protected override EntidadeBuscaModel CriandoListaGrid(object Entidade)
        {
            IngredienteModel ingrediente = new IngredienteModel();

            MercadoriaModel mercadoria = (MercadoriaModel)Entidade;

            ingrediente.Ingrediente = mercadoria;

            return new EntidadeBuscaModel() { Descricao = ingrediente.Ingrediente.Descricao, DataItem = ingrediente };
        }

    }
}
