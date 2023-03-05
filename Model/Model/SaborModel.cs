using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


   public class SaborModel
    {
        public int Id { get; set; }
        public string DescricaoSabor { get; set; }
         ClasseModel classe { get; set; }
        List<EngredienteModel>Engredientes { get; set; }
        public bool  Ativo{ get; set; }

    }

