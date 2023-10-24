using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Emumerator
{
    public enum ETipoMercadoria
    {

        None,

        [Description( description:"Ingrediente")]
        Ingrediente,

        [Description(description: "Insumo")]
        Insumo,

        [Description(description: "Embalagem")]
        Embalagem,

    }
}
