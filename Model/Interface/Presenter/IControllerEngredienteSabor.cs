using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public interface IControllerEngredienteSabor
{
    void StatusCadastro(EStatusCadastroTela status);
    void ExibirEngredienteSabor(List<EngredienteModel> Lista);
    void ExibirEngredienteCadastrados(List<EngredienteModel> Lista);
    List<EngredienteModel> GetEngredienteSabor();


}

