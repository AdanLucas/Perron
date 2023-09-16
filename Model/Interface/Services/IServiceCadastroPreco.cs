using System.Collections.Generic;


public interface IServiceCadastroPreco
{
    List<TamanhoModel> GetTamanhos();
    List<ClasseModel> GetClasses();
    List<PrecoModel> GetPrecoPorClasse(int IdClasse);
    void SalvarListaPrecos(List<PrecoModel> ListaPreco);
}

