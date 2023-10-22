using Model.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Perron.TelaBusca
{
    public class TelaBuscaIngrediente : TelaBuscaBase
    {

        public TelaBuscaIngrediente() : base( typeof(IngredienteModel)) { }

        protected override EntidadeBuscaModel CriandoListaGrid(object Entidade)
        {
            
            IngredienteModel entidade = (IngredienteModel)Entidade;

            return new EntidadeBuscaModel() {Descricao = entidade.Descricao,DataItem = entidade };
        }
     
    }
}
