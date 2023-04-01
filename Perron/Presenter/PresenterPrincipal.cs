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

        IPresenterEngrediente _controllerIngrediente;
        IPresenterSabor _controllerSabor;

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
            _view.EventoAbrirTelaCadastroSabor(EventoAbrirCadastroSabor);
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
            _controllerIngrediente = FactoryPresenter.CadastroIngredientes(_view);
        }
        private void EventoAbrirCadastroSabor(object o ,EventArgs e)
        {
            _controllerSabor = FactoryPresenter.CadastroSabor(_view);
        }

        #endregion

        #region Eventos Publicos





        #endregion

    }
}
