using Model.Emumerator;
using Perron.View;
using System.Windows.Forms;

namespace Perron.Controller
{
    public class ControllerTipoEmpresa : ControllerCadastroTipoPessoaBase
    {



        public ControllerTipoEmpresa() : base(ETipoPessoa.Empresa) { }



        protected override UserControl IniciarUserControl()
        {
            return new UCCadastroEmpresa();

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
        protected override void SalvarCadastro()
        {

        }


    }
}
