using System.Collections.Generic;


public interface IServiceProduto
{

    void Salvar(ProdutoModel produto);
    List<ProdutoModel> GetListaProduto(EStatusCadastro status);

    ProdutoModel GetporID(int Id);

}

