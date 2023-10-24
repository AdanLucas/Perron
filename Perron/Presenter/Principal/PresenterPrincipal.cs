using Model.Emumerator;
using System;
using System.Windows.Forms;

namespace Perron.Factory.Controller
{
    public class ControllerPrincipal : IPresenterPrincipal
    {

        private readonly IViewPrincipal _view;

        #region Presenters
        IPresenterMercadoria _presenterIngrediente;
        IPresenterProduto _presenterSabor;
        IPresenterClasse _presenterClasse;
        IPresenterCadastroTamanho _presenterTamanho;
        #endregion

        public ControllerPrincipal(IViewPrincipal view)
        {
            _view = view;

            _view.Show();
            DelegarEventos();

        }


        #region Metodos Privados
        private void DelegarEventos()
        {
            _view.EventoFechar(EventoFechar);
            _view.EventoAbrirTelaIngredientes(EventoAbrirCadastroIngrediente);
            _view.EventoAbrirTelaCadastroProduto(EventoAbrirCadastroSabor);
            _view.EventoAbrirtelaCadastroClasse(EventoAbrirCadastroClasse);
            _view.EventoAbrirtelaCadastroTAmanho(this.EventoAbrirCadastroTamanho);
            _view.EventoAbrirTelaCadastroPreco(EventoAbrirCadastroPreco);
            _view.EventoAbrirTelaCadastroPessoa(EventoAbrirCadastroPessoa);
        }


        #endregion

        #region Metodos Publicos

        #endregion

        #region Eventos Privados

        private void EventoFechar(object o, FormClosedEventArgs e)
        {
            Application.Exit();
        }
        private void EventoAbrirCadastroIngrediente(object o, EventArgs e)
        {
            _presenterIngrediente = FactoryPresenter.CadastroMercadoria(_view);
        }
        private void EventoAbrirCadastroSabor(object o, EventArgs e)
        {
            _presenterSabor = FactoryPresenter.CadastroProduto(_view);
        }
        private void EventoAbrirCadastroClasse(object o, EventArgs e)
        {
            _presenterClasse = FactoryPresenter.Classe(_view);
        }
        private void EventoAbrirCadastroTamanho(object o, EventArgs e)
        {
            _presenterTamanho = FactoryPresenter.CadastroTamanho(_view);
        }
        private void EventoAbrirCadastroPreco(object o, EventArgs e)
        {
            var CadastroPreco = FactoryPresenter.CadastroPreco(_view);
        }
        private void EventoAbrirCadastroPessoa(object o, EventArgs e)
        {
            var CadastroPreco = FactoryPresenter.CadastroPessoa((Form)_view, ETipoPessoa.Pessoa);
        }

        #endregion

        #region Eventos Publicos





        #endregion

    }
}
