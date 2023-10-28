using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.DTO
{
    public class ProdutoMercadoriaDTO: Aentity
    {
        public long? Produto { get; set; }
        public long? Mercadoria { get; set; }
    }
}
