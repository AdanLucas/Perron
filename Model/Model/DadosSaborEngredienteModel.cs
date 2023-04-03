using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


   public class DadosSaborEngredienteModel
    {
        public SaborModel Sabor { get; set; }
        public EngredienteModel Engrediente { get; set; }
        public TamanhoModel  Tamanho{ get; set; }
        public Decimal Quantidade{ get; set; }
        public EUnidadeMedida UnidadeMedida { get; set; }
        public bool Ativo { get; set; }


    }

