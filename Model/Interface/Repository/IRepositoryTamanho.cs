using System.Collections.Generic;


public interface IRepositoryTamanho
{
    void SalvarTamanho(TamanhoModel tamanho);
    TamanhoModel GetTamanhoPorId(int id);
    List<TamanhoModel> GetListaTamanho(EStatusCadastro status);
}

