using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Perron.Controller
{
    public class PresenterSabor : IPresenterSabor
    {

        private readonly IViewCadastroSabor _view;
        private IPresenterEngredienteSabor _presenterIngrediente;

        public PresenterSabor(IViewCadastroSabor view)
        {
            _view = view;
            SetarControllerIngrediente(_view.PainelEngredienteSabor);
            _view.Show();
            _presenterIngrediente.StatusCadastro(EStatusCadastroTela.Inicio);
            DelegarEventos();

        }

        #region Metodos Privados
        private void DelegarEventos()
        {
            _view.EventoNovo(this.EventoNovo);
            _view.EventoSalvar(this.EventoSalvar);
            _view.EventoDeletar(this.EventoRemover);
            _view.EventoCancelar(this.EventoCancelar);



        }

        private void SetarControllerIngrediente(Panel painel)
        {

            _presenterIngrediente = FactoryPresenter.EngredienteSabor(painel);

        }


        #endregion

        #region Metodos Publicos

        #endregion

        #region Eventos privados

        private void EventoNovo(object o , EventArgs e)
        {
            _presenterIngrediente.StatusCadastro(EStatusCadastroTela.Cadastrando);

        }
        private void EventoSalvar(object o, EventArgs e)
        {
            _presenterIngrediente.StatusCadastro(EStatusCadastroTela.Inicio);
        }
        private void EventoRemover(object o, EventArgs e)
        {
            _presenterIngrediente.StatusCadastro(EStatusCadastroTela.Inicio);
        }
        private void EventoCancelar(object o, EventArgs e)
        {
            _presenterIngrediente.StatusCadastro(EStatusCadastroTela.Inicio);
        }

        #endregion

    }
}
