using System;
using System.Collections.Generic;


public interface IServiceCadastroPreco
{
    List<TamanhoModel> GetTamanhos();
    List<ClasseModel> GetClasses();
    List<PrecoModel> GetPrecoPorClasse(int IdClasse);
    void SalvarListaPrecos(params object[] parametro);
    void RemoverTodosVinculoDeClasseComPrecos(Int64? IdClasse);
    void RemoverVinculoPrecoComClasse(Int64? IdClasse, Int64? IdPreco);
}

