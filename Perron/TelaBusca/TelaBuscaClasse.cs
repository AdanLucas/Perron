using Model.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Perron.TelaBusca
{
    public class TelaBuscaClasse : TelaBuscaBase
    {

        public TelaBuscaClasse() : base(typeof(ClasseModel)) { }


        protected override EntidadeBuscaModel CriandoListaGrid(object Entidade)
        {
            throw new NotImplementedException();
        }
    }
}
