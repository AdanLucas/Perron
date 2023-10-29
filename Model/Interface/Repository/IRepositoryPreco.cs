using System;
using System.Collections.Generic;


public interface IRepositoryPreco
{
    void SalvarListaPreco(params object[] parametro);
    void SalvarPreco(PrecoModel preco);
    List<PrecoModel> GetListaPrecoPorClasse(int IDClasse);
    List<PrecoModel> GetListaPreco(EStatusCadastro status);
    void RemoverTodosVinculoClassePreco(Int64? IdClasse);
    void RemoverVinculoPrecoClasse(Int64? IdClasse, Int64? IdPreco);
}

