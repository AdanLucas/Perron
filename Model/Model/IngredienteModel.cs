using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Model
{
    public class IngredienteModel : Aentity
    {
        public MercadoriaModel Ingrediente { get; set; }

        public List<DadosIngredienteModel> DadosIngrediente;

        


    }
}
