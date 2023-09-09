using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public interface IPresenterIngredienteSabor
{
    
    List<EngredienteModel> GetIngredienteSabor();
    void SetListaIngredienteSabor(List<EngredienteModel>Lista);
    void EventoAtualizarStatusCadastro(EComportamentoTela status);
}

