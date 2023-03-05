using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Perron.Controller
{
    public class ControllerIngrediente : IControllerIngrediente
    {
        

        private readonly IViewCadastroIngrediente _view;


        public ControllerIngrediente(IViewCadastroIngrediente view)
        {
            _view = view;
            _view.Show();
            DelegarEventos();
        }


        #region metodos Privados
        private void DelegarEventos()
        {
            _view.EventoGrid(EventoGrid);

        }

        #endregion

        #region Metodos Publicos



        #endregion

        #region Eventos Privados
        private void EventoGrid(object o, EventArgs e)
        {

        }


        #endregion

        #region Metodos Publicos

        #endregion


        

        
    }
}
