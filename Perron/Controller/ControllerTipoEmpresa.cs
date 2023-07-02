using Model.Emumerator;
using Model.Model;
using Services.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Perron.Controller
{
    public class ControllerTipoEmpresa : ControllerCadastroTipoPessoaBase
    {
        public ControllerTipoEmpresa(): base(ETipoPessoa.Empresa) {  }

    }
}
