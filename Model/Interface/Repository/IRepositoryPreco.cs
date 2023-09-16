using System.Collections.Generic;


public interface IRepositoryPreco
{
    void SalvarListaPreco(List<PrecoModel> Lista);
    void SalvarPreco(PrecoModel preco);
    List<PrecoModel> GetListaPrecoPorClasse(int IDClasse);
    List<PrecoModel> GetListaPreco(EStatusCadastro status);
}

