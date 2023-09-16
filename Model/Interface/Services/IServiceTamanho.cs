using System.Collections.Generic;


public interface IServiceTamanho
{
    void Salvar(TamanhoModel tamanho);

    List<TamanhoModel> GetListaTamanho(EStatusCadastro status);

}

