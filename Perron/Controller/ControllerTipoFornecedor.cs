using Model.Emumerator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Perron.Controller
{
    public class ControllerTipoFornecedor : ControllerCadastroTipoPessoaBase
    {



        public ControllerTipoFornecedor(): base(ETipoPessoa.Fornecedor) { }


        public override void SetarUserEmTabPage(TabPage page)
        {
            
        }

    }
}
