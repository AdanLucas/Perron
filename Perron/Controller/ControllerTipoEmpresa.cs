using Model.Emumerator;
using Model.Model;
using Perron.View;
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

        private UCCadastoFornecedor _view;

        public ControllerTipoEmpresa(): base(ETipoPessoa.Empresa) {  }



        public override void SetarUserEmTabPage(TabPage page)
        {
            _view = new UCCadastoFornecedor();
            page.Controls.Add(_view);
        }

        protected override void ComportamentoCadastrando()
        {
            
        }
        protected override void ComportamentoNone()
        {
            
        }
        protected override void ComportamentoInicio()
        {
            
        }
        protected override void ComportamentoNovo()
        {
            
        }
        protected override void ComportamentoPopularCadastrando()
        {
            
        }
        protected override void SalvarCadastro(bool ativo)
        {
            
        }


    }
}
