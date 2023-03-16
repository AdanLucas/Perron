using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Perron.Controller
{
    public class PresenterEngredienteSabor : IControllerEngredienteSabor
    {
        private readonly IViewCadastroEngredienteSabor _view;

        public PresenterEngredienteSabor(IViewCadastroEngredienteSabor view)
        {
            _view = view;
        }

        public void ExibirEngredienteCadastrados(List<EngredienteModel> Lista)
        {
            throw new NotImplementedException();
        }

        public void ExibirEngredienteSabor(List<EngredienteModel> Lista)
        {
            throw new NotImplementedException();
        }

        public List<EngredienteModel> GetEngredienteSabor()
        {
            throw new NotImplementedException();
        }

        public void StatusCadastro(EStatusCadastroTela status)
        {
            throw new NotImplementedException();
        }
    }
}
