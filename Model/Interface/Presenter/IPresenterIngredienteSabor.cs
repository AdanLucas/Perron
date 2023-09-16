using System.Collections.Generic;


public interface IPresenterIngredienteSabor
{

    List<EngredienteModel> GetIngredienteSabor();
    void SetListaIngredienteSabor(List<EngredienteModel> Lista);
    void EventoAtualizarStatusCadastro(EComportamentoTela status);
}

