using Model.AtribulteClasses;
using Model.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Emumerator
{
    public enum ETipoBusca
    {
        [AtributoTipoBusca(Tipo = typeof(MercadoriaDTO))]
        MERCADORIA,

        [AtributoTipoBusca(Tipo = typeof(PessoaModel))]
        PESSOA,

        [AtributoTipoBusca(Tipo = typeof(ClasseModel))]
        CLASSE,

        [AtributoTipoBusca(Tipo = typeof(IngredienteModel))]
        INGREDIENTE
    }
}
