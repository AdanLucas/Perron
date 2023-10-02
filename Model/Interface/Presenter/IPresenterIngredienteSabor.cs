using System.Collections.Generic;


public interface IPresenterIngredienteSabor
{

    List<IngredienteModel> GetIngredienteSabor();
    void SetListaIngredienteSabor(List<IngredienteModel> Lista);
    void EventoAtualizarStatusCadastro(EComportamentoTela status);
}

