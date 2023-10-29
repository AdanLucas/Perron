using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.DTO
{
    public class PrecoDTO : Aentity
    {
        public long IdTamanho { get; set; }
        public  decimal Preco { get; set; }
    }
}
