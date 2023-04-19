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
        private EStatusCadastroTela StatusTela;
        public   StatusCadastroTelaEventhandler EventoCadastro;

        public GerenciarStatusCadastro(IViewPadraoCadastro view)
        {
            _view = view;
        }

        private void NotificarEvento()
        {
            if (EventoCadastro != null)
                EventoCadastro(this, new StatusCadastroTelaEventArgs { statusTela = StatusTela });
        }


    }
}
