﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.DTO
{
    public class MercadoriaDTO : Aentity
    {
        public string Descricao { get; set; }
        public int TipoMercadoria { get; set; }
        public int TipoMedida { get; set; }
    }
}
