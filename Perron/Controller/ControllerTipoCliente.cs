using Model.Emumerator;
using Perron.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Perron.Controller
{
    public class ControllerTipoCliente : ControllerCadastroTipoPessoaBase
    {
        private UCCliente _view;
        public ControllerTipoCliente(): base(ETipoPessoa.Cliente) { }

        public override void SetarUserEmTabPage(TabPage page)
        {
            _view = new UCCliente();
            page.Controls.Add( _view );
        }

    }
}
