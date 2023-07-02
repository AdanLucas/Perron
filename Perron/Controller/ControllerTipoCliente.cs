using Model.Emumerator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Perron.Controller
{
    public class ControllerTipoCliente : ControllerCadastroTipoPessoaBase
    {
        public ControllerTipoCliente(): base(ETipoPessoa.Cliente) { } 

    }
}
