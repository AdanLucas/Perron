﻿using Model.AtribulteClasses;
using Model.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Perron.TelaBusca.Enum
{
    public enum ETipoBusca
    {
        [AtributoTipoBusca(Tipo = typeof(MercadoriaDTO))]
        MERCADORIA,

        [AtributoTipoBusca(Tipo = typeof(PessoaModel))]
        PESSOA,

        [AtributoTipoBusca(Tipo = typeof(TelaBuscaClasse))]
        CLASSE,

        [AtributoTipoBusca(Tipo = typeof(TelaBuscaIngrediente))]
        INGREDIENTE
    }
}
