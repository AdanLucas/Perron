using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Perron.Factory.Controller
{
    public class ControllerPrincipal : IControllerPrincipal
    {

        private readonly IViewPrincipal _view;


        #region Controllers

        IControllerIngrediente _controllerIngrediente;

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
            _controllerIngrediente = FactoryController.CadastroIngredientes(_view);
        }


        #endregion

        #region Eventos Publicos





        #endregion

    }
}
