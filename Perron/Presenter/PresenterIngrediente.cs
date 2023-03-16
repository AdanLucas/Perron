using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Perron.Controller
{
    public class PresenterIngrediente : PresenterPadrao , IControllerIngrediente
    {
        private readonly IViewCadastroIngrediente _view;

        public PresenterIngrediente(IViewCadastroIngrediente view) : base(view)
        {
            _view = view;
            _view.Show();
            DelegarEventos();
        }


        #region metodos Privados
        private void DelegarEventos()
        {
            _view.EventoGrid(EventoGrid);
            _view.EventoCancelar(EventoCancelar);
            _view.EventoDeletar(EventoDeletar);
            _view.EventoNovo(EventoNovo);
            _view.EventoSalvar(EventoSalvar);
        }

        #endregion

        #region Metodos Publicos



        #endregion

        #region Eventos Privados

        private void EventoGrid(object o, EventArgs e)
        {

        }
        public void EventoNovo(object o, EventArgs e)
        {
            throw new NotImplementedException();
        }
        public void EventoSalvar(object o, EventArgs e)
        {
            throw new NotImplementedException();
        }
        public void EventoDeletar(object o, EventArgs e)
        {
            throw new NotImplementedException();
        }
        public void EventoCancelar(object o, EventArgs e)
        {
            throw new NotImplementedException();
        }


        #endregion

        #region Metodos Publicos

        #endregion





    }
}
