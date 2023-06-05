using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Perron.Factory.Controller
{
    public class ControllerPrincipal : IPresenterPrincipal
    {

        private readonly IViewPrincipal _view;


        #region Controllers

        IPresenterEngrediente _presenterIngrediente;
        IPresenterSabor _presenterSabor;
        IPresenterClasse _presenterClasse;
        IPresenterCadastroTamanho _presenterTamanho;

        #endregion

        public ControllerPrincipal(IViewPrincipal view)
        {
            _view = view;
            
            _view.Show();
            DelegarEventos();
            var dados = ConfiguracoesGlobais.Instancia.ConfiguracaoInicial.API;
        }
            

        #region Metodos Privados
        private void DelegarEventos()
        {
            _view.EventoFechar(EventoFechar);
            _view.EventoAbrirTelaIngredientes(EventoAbrirCadastroIngrediente);
            _view.EventoAbrirTelaCadastroSabor(EventoAbrirCadastroSabor);
            _view.EventoAbrirtelaCadastroClasse(EventoAbrirCadastroClasse);
            _view.EventoAbrirtelaCadastroTAmanho(this.EventoAbrirCadastroTamanho);
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
            _presenterIngrediente = FactoryPresenter.CadastroIngredientes(_view);
        }
        private void EventoAbrirCadastroSabor(object o ,EventArgs e)
        {
            _presenterSabor = FactoryPresenter.CadastroSabor(_view);
        }
        private void EventoAbrirCadastroClasse(object o, EventArgs e)
        {
            _presenterClasse = FactoryPresenter.Classe(_view); 
        }
        private void EventoAbrirCadastroTamanho(object o, EventArgs e)
        {
            _presenterTamanho = FactoryPresenter.CadastroTamanho(_view);
        }

        #endregion

        #region Eventos Publicos





        #endregion

    }
}
