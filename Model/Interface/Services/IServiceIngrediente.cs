using System.Collections.Generic;


public interface IServiceIngrediente
{
    List<IngredienteModel> GetListaEngredientesCadastroados();
    void Salvar(IngredienteModel Engrediente);
    void SalvarLista(List<IngredienteModel> ListaEngrediente);

}

