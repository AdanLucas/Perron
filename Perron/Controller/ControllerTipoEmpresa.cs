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
    public class ControllerTipoEmpresa : IControllerTipoPessoa
    {
        private EComportamentoTela? _compartamento;
        private PessoaModel _pessoa;

        private IServiceTipoPessoa _serivce = FactoryService.CadastroTipoPessoa(ETipoPessoa.Empresa);
        public void EventoComportamento(object o, EventArgsGenerico<object[]> e)
        {
             _compartamento = (EComportamentoTela)e.Item[0];
             _pessoa = (PessoaModel)e.Item[1];
        }

        public void Salvar(int IdPessoa, bool status)
        {
            
        }
        public void SetarUserEmTabPage(TabPage page)
        {
            
        }
    }
}
