using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Perron.Controller
{
    public class PresenterSabor : IControllerSabor
    {

        private readonly IViewCadastroSabor _view;
        private IControllerEngredienteSabor _controllerIngrediente;

        public PresenterSabor(IViewCadastroSabor view)
        {
            _view = view;
            SetarControllerIngrediente(_view.PainelEngredienteSabor);
            _view.Show();
        }

        #region Metodos Publicos
        private void SetarControllerIngrediente(Panel painel)
        {

            _controllerIngrediente = FactoryController.EngredienteSabor(painel);

        }


        #endregion



    }
}
