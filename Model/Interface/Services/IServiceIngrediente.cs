using System.Collections.Generic;


public interface IServiceIngrediente
{
    List<EngredienteModel> GetListaEngredientesCadastroados();
    void Salvar(EngredienteModel Engrediente);
    void SalvarLista(List<EngredienteModel> ListaEngrediente);

}

