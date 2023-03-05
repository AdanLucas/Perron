using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Perron.Controller
{
    public abstract class ControllerPadrao
    {
        private readonly IViewPadraoCadastro _view;

        public ControllerPadrao(IViewPadraoCadastro view)
        {
            _view = view;
        }

        public void EstadoBotoes(EStatusCadastroTela statusTela)
        {
            switch (statusTela)
            {
                case EStatusCadastroTela.None:

                    _view.VisibilidadeBotaoDeletar = false;
                    _view.VisibilidadeBotaoNovo = false;
                    _view.VisibilidadeBotaoSalvar = false;
                    _view.VisibilidadeBotaoCancelar = false;

                    break;

                case EStatusCadastroTela.Inicio:

                    _view.VisibilidadeBotaoDeletar = false;
                    _view.VisibilidadeBotaoNovo = true;
                    _view.VisibilidadeBotaoSalvar = false;
                    _view.VisibilidadeBotaoCancelar = true;

                    break;

                case EStatusCadastroTela.Cadastrando:

                    _view.VisibilidadeBotaoDeletar = false;
                    _view.VisibilidadeBotaoNovo = false;
                    _view.VisibilidadeBotaoSalvar = true;
                    _view.VisibilidadeBotaoCancelar = true;

                    break;

                case EStatusCadastroTela.ItemSelecionado:

                    _view.VisibilidadeBotaoDeletar = true;
                    _view.VisibilidadeBotaoNovo = false;
                    _view.VisibilidadeBotaoSalvar = true;
                    _view.VisibilidadeBotaoCancelar = true;

                    break;

                default:
                    break;
            }
        }


    }


}
