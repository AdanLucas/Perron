using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Perron.Outros
{

    public  class GerenciarStatusCadastro
    {

        private  IViewPadraoCadastro _view;
        private EComportamentoTela _comportamentoAtual;
        public   ComportamentoTelaEventHandler EventoComportamentoAtual;

        public GerenciarStatusCadastro(IViewPadraoCadastro view)
        {
            _view = view;
        }

        private void NotificarEvento()
        {
            if (EventoComportamentoAtual != null)
                EventoComportamentoAtual(this, new ComportamentoTelaEventArgs { StatusTela = _comportamentoAtual });
        }


    }
}
